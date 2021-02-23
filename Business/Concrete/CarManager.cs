using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }


        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> Get()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Car entity)
        {
            if (entity.CarName.Length < 2)
            {
                return new ErrorResult("Car Name is too short");
            }

            if (entity.DailyPrice <= 0)
            {
                return new ErrorResult("Daily Price can not be 0");
            }

            _carDal.Add(entity);

            return new SuccessResult("Car Added");

        }

        public IResult Update(Car entity)
        {
          _carDal.Update(entity);
          return new SuccessResult("Updated");
        }

        public IResult Delete(Car entity)
        {
           _carDal.Delete(entity);
           return new SuccessResult("Deleted");
        }

        public IDataResult<List<Car>> GetByColorID()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByBrandID()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }
    }
}
