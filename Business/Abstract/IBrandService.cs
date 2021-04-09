using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<BrandDetailDto>> GetBrandDetails();
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<List<Brand>> GetAll();

        IDataResult<List<Brand>> GetAllById(int BrandId);
    }
}