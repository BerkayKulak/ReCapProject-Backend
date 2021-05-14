using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalsByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalByCustomerId(int customerId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult EndRental(Rental rental);
        IResult isCarAvailable(Rental rental);
        IResult AddTrasactionalTest(Rental rental);
    }
}
