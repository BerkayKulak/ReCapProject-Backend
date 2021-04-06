using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2018",DailyPrice=245,Description="Binek BMW M3 kırmızı 2018 model günlüğü 245 tl"},
                new Car{CarId=1,BrandId=3,ColorId=3,ModelYear="2020",DailyPrice=245,Description="Binek Volkswagen Tiguan mavi 2020 model günlüğü 245 tl"},
                new Car{CarId=1,BrandId=2,ColorId=4,ModelYear="2019",DailyPrice=245,Description="Binek Mercedes A 180 AMG beyaz 2019 model günlüğü 245 tl"},
                new Car{CarId=2,BrandId=4,ColorId=1,ModelYear="2019",DailyPrice=318,Description="Ticari Renault Kangoo kırmızı 2019 model günlüğü 318 tl"},
                new Car{CarId=2,BrandId=3,ColorId=4,ModelYear="2019",DailyPrice=318,Description="Ticari Volkswagen Caddy beyaz 2019 model günlüğü 318 tl"},
                new Car{CarId=3,BrandId=2,ColorId=2,ModelYear="2020",DailyPrice=350,Description="Servis Mercedes Sprinter siyah 2020 model günlüğü 350 tl"},
                new Car{CarId=3,BrandId=3,ColorId=2,ModelYear="2021",DailyPrice=350,Description="Servis Volkswagen  Transporter siyah 2021 model günlüğü 350 tl"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId && c.BrandId == car.BrandId && c.ColorId == car.ColorId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId && c.BrandId == car.BrandId && c.ColorId == car.ColorId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}