using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Add(Car car)
        {
            if(car.Description.Length<2)
            {
                return new ErrorResult("Car Description is too short");
            }

            if (car.DailyPrice <= 0)
            {
                return new ErrorResult("Daily Price can not be 0");
            }

            _carDal.Add(car);

            return new SuccessResult("Car Added");

            

            
        }

        public IDataResult<Car> Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessDataResult<Car>();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByBrandID()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByColorID()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetByID()
        {
            throw new NotImplementedException();
        }
    }
}
