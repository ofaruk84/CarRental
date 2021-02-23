
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;

namespace Business.Abstract
{
   public interface ICarService : IServiceRepository<Car>
    {

        IDataResult<List<Car>> GetByColorID();
        IDataResult<List<Car>> GetByBrandID();
        IDataResult<List<CarDetailDto>> GetCarsDetails();

    }
}
