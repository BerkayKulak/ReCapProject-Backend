using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImages carImage);
        IResult Delete(CarImages carImage);
        IResult Update(IFormFile file, CarImages carImage);
        IDataResult<CarImages> Get(int id);
        IDataResult<List<CarImages>> GetAll();
        IDataResult<List<CarImages>> GetImagesByCarId(int id);
    }
}