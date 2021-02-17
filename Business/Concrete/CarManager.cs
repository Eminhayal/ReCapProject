using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Constants;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal= carDal;
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(filter));
        }

        IResult IBaseService<Car>.Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Failed);
            }
        }

        IResult IBaseService<Car>.Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        IDataResult<List<Car>> IBaseService<Car>.GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        IDataResult<List<Car>> ICarService.GetByDailyPrice(decimal min, decimal max)
        {
            return new DataResult<List<Car>>( _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max),true);
        }

        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int id)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), true);
        }

        IDataResult<List<Car>> ICarService.GetCarsByColorId(int id)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), true);
        }

        IResult IBaseService<Car>.Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.Updated);
            }
            else
            {
                return new ErrorResult(Messages.Failed);
            }
        }
    }
}
