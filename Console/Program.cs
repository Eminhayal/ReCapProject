using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { Id= 1001 , Name= "BMW" , BrandId= 1 , ColorId = 1 ,
            //    DailyPrice = 500 , ModelYear=2015, Description = "Spor Araba / Otomatik Vites"});
            //foreach (var Cars in carManager.GetAll())
            //{
            //    System.Console.WriteLine(Cars.Name);
            //}
            IColorService ColorManager = new ColorManager(new EfColorDal());

            foreach (var colors in ColorManager.GetAll().Data)
            {
                System.Console.WriteLine($"{colors.ColorId}\t{colors.ColorName}");
            }
            //fg keyleri ata
           
        }
    }
}
