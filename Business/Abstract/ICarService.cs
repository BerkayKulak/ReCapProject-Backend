using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IServices<Car>
    {
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        public List<CarDetailDto> GetCarDetails();
    }
}