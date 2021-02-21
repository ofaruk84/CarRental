using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>,ICarDal
    {
    }
}
