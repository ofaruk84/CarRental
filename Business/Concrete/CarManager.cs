﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;

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
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car entity)
        {


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

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }
    }
}
