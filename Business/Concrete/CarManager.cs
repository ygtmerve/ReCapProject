﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 &&car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Araba eklenemedi");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
