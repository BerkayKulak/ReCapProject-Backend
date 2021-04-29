using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<Car> GetById(int carId);
        DataResult<List<Car>> GetByDailyPrice();

        IResult Add(Car car);
        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult AddTransactionalTest(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);

        IDataResult<List<CarDetailDto>> GetDtoBrandAndColorId(int brandId, int colorId);
    }
}