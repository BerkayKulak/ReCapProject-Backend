using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;// bağımlılığı azalttık intefaceden alıyoruz
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour == 22)
             {
                return new ErrorDataResult();
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),true,"Ürünler Listelendi");
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public IResult Add(Car car)
        {

            if (car.Description.Length < 2)
            {   
                // magic strings
                return new ErrorResult(Messages.CarNameInvalid);
            }
            else if (car.DailyPrice < 1)
            {
                return new ErrorResult(Messages.CarRent);
            }
            else
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public Car getById(int carId)
        {
            return _carDal.Get(p=>p.CarId== carId);
        }
    }
}