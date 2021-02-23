using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from re in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join us in context.Users
                             on cu.UserId equals us.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CarName = ca.CarName,
                                 CustomerName = cu.CompanyName,
                                 UserName = us.FirstName+ " " + us.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,              
                             };
                return result.ToList();

            }
        }
    }
}
