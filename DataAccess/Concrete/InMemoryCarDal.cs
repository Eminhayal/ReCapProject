using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id= 1 , BrandId = 2 , ColorId = 1 , DailyPrice= 1000 , ModelYear = 2017 , Description= "Spor Araba" },
                new Car { Id= 2 , BrandId = 1 , ColorId = 1 , DailyPrice= 800 , ModelYear = 2020 , Description= "Aile Arabası" },
                new Car { Id= 3 , BrandId = 2 , ColorId = 2 , DailyPrice= 700 , ModelYear = 2014 , Description= "Spor Araba" },
                new Car { Id= 4 , BrandId = 1 , ColorId = 4 , DailyPrice= 600 , ModelYear = 2019 , Description= "Aile Arabası" },
                new Car { Id= 5 , BrandId = 2 , ColorId = 3 , DailyPrice= 500 , ModelYear = 2012 , Description= "Spor Araba " },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int Id)
        {
           return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
