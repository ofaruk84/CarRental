using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByID();
        IDataResult<List<Car>> GetByColorID();
        IDataResult<List<Car>> GetByBrandID();
        IResult Add(Car car);
        IDataResult<Car> Delete(Car car);
        


    }
}
