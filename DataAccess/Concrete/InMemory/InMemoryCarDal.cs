using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2002, DailyPrice=30000, Description="Peugeot"},
                new Car {Id=2, BrandId=2, ColorId=2, ModelYear=2010, DailyPrice=100000, Description="Mercedes"},
                new Car {Id=3, BrandId=3, ColorId=3, ModelYear=2008, DailyPrice=80000, Description="Nissan"},
                new Car {Id=4, BrandId=4, ColorId=4, ModelYear=2004, DailyPrice=60000, Description="Audi"},
                new Car {Id=5, BrandId=2, ColorId=5, ModelYear=2005, DailyPrice=70000, Description="Mercedes"},
                new Car {Id=6, BrandId=5, ColorId=6, ModelYear=2016, DailyPrice=90000, Description="Fiat"},
                new Car {Id=7, BrandId=5, ColorId=7, ModelYear=2013, DailyPrice=35000, Description="Fiat"},
                new Car {Id=8, BrandId=1, ColorId=8, ModelYear=2000, DailyPrice=65000, Description="Peugeot"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
