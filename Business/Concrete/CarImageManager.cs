using Business.Abstract;
using Business.Constants;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDal _carImageDAL;

        public CarImageManager(ICarImageDal carImageDAL)
        {
            _carImageDAL = carImageDAL;
        }


        public IResult Add(IFormFile file, CarImages carImage)
        {
            IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = CarImageFileHelper.Add(file);
            carImage.History = DateTime.Now;
            _carImageDAL.Add(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImages carImage)
        {
            CarImageFileHelper.Delete(carImage.ImagePath);
            _carImageDAL.Delete(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImages carImage)
        {
            IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDAL.Get(p => p.Id == carImage.Id).ImagePath;

            carImage.ImagePath = CarImageFileHelper.Update(oldPath, file);
            carImage.History = DateTime.Now;
            _carImageDAL.Update(carImage);
            return new SuccessResult();
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImages> Get(int id)
        {
            return new SuccessDataResult<CarImages>(_carImageDAL.Get(p => p.Id == id));
        }


        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImageDAL.GetAll());
        }


        public IDataResult<List<CarImages>> GetImagesByCarId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(id));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImages>>(result.Message);
            }

            return new SuccessDataResult<List<CarImages>>(CheckIfCarImageNull(id).Data);
        }

        //business rules
        private IResult CheckImageLimitExceeded(int carId)
        {
            var carImageCount = _carImageDAL.GetAll(p => p.CarId == carId).Count;
            if (carImageCount >= 5)
            {
                return new ErrorResult(Messages.CarImageCountLimitExceeded);
            }

            return new SuccessResult();
        }


        private IDataResult<List<CarImages>> CheckIfCarImageNull(int id)
        {
            try
            {
                string path = @"\images\defaultImage.jpg";
                var result = _carImageDAL.GetAll(c => c.CarId == id).Any();
                if (!result)
                {
                    List<CarImages> carImage = new List<CarImages>();
                    carImage.Add(new CarImages { CarId = id, ImagePath = path, History = DateTime.Now });
                    return new SuccessDataResult<List<CarImages>>(carImage);
                }
            }
            catch (Exception exception)
            {
                return new ErrorDataResult<List<CarImages>>(exception.Message);
            }
            return new SuccessDataResult<List<CarImages>>(_carImageDAL.GetAll(c => c.CarId == id));
        }
    }
}