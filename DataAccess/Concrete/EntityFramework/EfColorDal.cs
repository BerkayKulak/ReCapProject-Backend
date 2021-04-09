using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Colors
                             join b in context.Brands
                             on c.ColorId equals b.BrandId
                             select new ColorDetailDto
                             {
                                 ColorName = c.ColorName,
                                 ColorId = c.ColorId,
                                 BrandName = b.BrandName,
                                 BrandId = b.BrandId
                             };
                return result.ToList();


            }
        }

       
    }
}