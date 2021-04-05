using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=2, ColorId=1, ModelYear=2020, DailyPrice=150000, Description="Mercedes S"},
                new Car{Id=2, BrandId=3, ColorId=5, ModelYear=2003, DailyPrice=193000, Description="Tofaş"},
                new Car{Id=3, BrandId=4, ColorId=3, ModelYear=2007, DailyPrice=136000, Description="BMW"},
                new Car{Id=4, BrandId=1, ColorId=2, ModelYear=2018, DailyPrice=220000, Description="PORSCHE"},
                new Car{Id=5, BrandId=2, ColorId=1, ModelYear=2016, DailyPrice=142000, Description="FIAT"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Id + " Eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            //foreach (var c in _cars)
            //{
            //    if (car.Id==c.Id)
            //    {
            //        carToDelete = c;
            //    }
            //}


            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            Console.WriteLine(car.Id + " Silindi");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
