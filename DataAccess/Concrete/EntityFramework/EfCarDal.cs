using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto()
                             {
                                 ImagePath = (from x in context.CarImages where x.CarId == ca.Id select x.ImagePath).FirstOrDefault(),
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 Id = ca.Id,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }

        public CarDetailDto GetCarDetailsById(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto()
                             {
                                 ImagePath = (from x in context.CarImages where x.CarId == ca.Id select x.ImagePath).FirstOrDefault(),
                                 BrandId = ca.BrandId,
                                 ColorId = ca.ColorId,
                                 Id = ca.Id,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return result.FirstOrDefault(filter);
            }
        }
    }
}