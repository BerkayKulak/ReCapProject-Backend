using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cu in context.Customers
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new CustomerDetailDto { Id = cu.Id, UserId = us.Id, CompanyName = cu.CompanyName, FirstName = us.FirstName, LastName = us.LastName };

                return result.ToList();

            }
        }
    }
}