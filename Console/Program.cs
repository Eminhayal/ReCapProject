﻿using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAll())
            {
                System.Console.WriteLine(cars.Id);
            }

        }
    }
}
