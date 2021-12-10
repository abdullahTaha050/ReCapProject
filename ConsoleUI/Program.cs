using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAddTest();

            GetCarsByBrandIdTest();

            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " / "+ car.BrandName + " / "+ car.ColorName + " / "+ car.DailyPrice);
            }

        }

        private static void GetCarsByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car2 = new Car { 
                Id = 2,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 150,
                Description = "Benzinli Manuel 1.2",
                ModelYear = "2020",
                CarName = "Volkswagen Polo"

            };
            carManager.Add(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
