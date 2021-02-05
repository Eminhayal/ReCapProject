using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            //carManager1.Add(new Car {Id= 2 , BrandId= 2 , ColorId= 2 , DailyPrice= 500, Description="Spor Araba" , ModelYear= 2015});

            foreach (var cars in carManager1.GetAll())
            {
                System.Console.WriteLine(cars.Id);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());

             //brandManager.Add(new Brand { BrandId = 2, Name = "BMW" });
             // Ekledikten sonra aynı ıd de bir daha ekleyemeyeceği için hata veriyor
            foreach (var brands in brandManager.GetAll())
            {
                System.Console.WriteLine(brands.BrandId);
            }
            ColorManager colorManager = new ColorManager(new EfColorDal());
             //colorManager.Add(new Color { ColorId = 2, Name = "Red" });
        }
    }
}
