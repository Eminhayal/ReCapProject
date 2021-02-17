using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        IResult IBaseService<Brand>.Add(Brand brand)
        {
            if(brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Failed);
            }
        }

        IResult IBaseService<Brand>.Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

        IDataResult<List<Brand>> IBaseService<Brand>.GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.Listed);
        }

        IResult IBaseService<Brand>.Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.Updated);
            }
            else
            {
                return new ErrorResult(Messages.Failed);
            }
        }
    }
}
