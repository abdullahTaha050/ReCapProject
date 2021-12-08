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
            CarManager carManager = new CarManager(new EfCarDal());
            
            //Car car1 = new Car { 
            //    Id = 1,
            //    BrandId = 1,
            //    ColorId = 2,
            //    DailyPrice = 100,
            //    Description = "Dizel Otomatik C Segmenti Araç",
            //    ModelYear = "2021",
            //    Name = "Renault Clio"

            //};
            //carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
