using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarName = ca.CarName, BrandName = b.BrandName,
                                 ColorName = co.ColorName, DailyPrice = ca.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
