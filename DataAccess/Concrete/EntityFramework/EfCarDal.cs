using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, CarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join a in context.Colors
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = a.ColorName,DailyPrice=c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
