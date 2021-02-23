using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using(CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice
                             };

                return result.ToList();
            }
        
            
        }
    }
}
