using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var results = _rentalDal.GetAll(re => re.CarId == rental.CarId);

            foreach (var result in results)
            {
                if (result.ReturnDate == null ||
                    (rental.RentDate >= result.RentDate && rental.RentDate <= result.ReturnDate) ||
                    (rental.ReturnDate >= result.RentDate && rental.RentDate <= result.ReturnDate))
                {
                    return new ErrorResult(Messages.RentalError);
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(re => re.Id == Id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult EndRental(Rental rental)
        {
            var result = _rentalDal.GetAll();
            var updatedRental = result.LastOrDefault();
            if (updatedRental.ReturnDate != null && updatedRental.RentDate < DateTime.Now && updatedRental.ReturnDate > DateTime.Now)
            {
                updatedRental.ReturnDate = DateTime.Now;
                _rentalDal.Update(updatedRental);
                return new SuccessResult(Messages.SuccessRentalUpdate);
            }

            return new ErrorResult(Messages.ErrorRentalUpdate);
        }

        [TransactionScopeAspect]
        public IResult AddTrasactionalTest(Rental rental)
        {

            Add(rental);

            if (rental.ReturnDate < DateTime.Now)
            {
                throw new Exception("İşlem başarısız");
            }

            Add(rental);

            return null;
        }

        public IResult isCarAvailable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);

            if (result.Any(r => r.RentDate != null && r.ReturnDate == null))
            {
                return new ErrorResult(Messages.CarIsNotAvailable);
            }
            else
            {
                return new SuccessResult();
            }
        }

        public IDataResult<List<RentalDetailDto>> GetRentalsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(r => r.CarId == carId));
        }


        public IDataResult<List<RentalDetailDto>> GetRentalByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(r => r.CustomerId == customerId));
        }

    }
}