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
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from b in context.Brands
                             join c in context.Colors
                             on b.BrandId equals c.ColorId
                             select new BrandDetailDto
                             {
                                 BrandName = b.BrandName,
                                 BrandId = b.BrandId,
                                 ColorName = c.ColorName,
                                 ColorId = c.ColorId
                             };
                return result.ToList();


            }
        }
    }
}