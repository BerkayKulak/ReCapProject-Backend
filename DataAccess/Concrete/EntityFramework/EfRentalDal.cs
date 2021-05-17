using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cu in context.Customers
                             on re.CustomerId equals cu.Id
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join us in context.Users
                             on cu.UserId equals us.Id

                             select new RentalDetailDto
                             {
                                 ModelYear = ca.ModelYear,
                                 CarId = ca.Id,
                                 Id = re.Id,
                                 CarName = ca.CarName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 CompanyName = cu.CompanyName,
                                 BrandName = br.BrandName,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 CustomerId = cu.Id
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }

}
