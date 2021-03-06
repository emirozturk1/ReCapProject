﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
           
            GetItem(carManager.GetByCarId(1));

            GetList(carManager.GetAll());

            
            carManager.Delete(new Car { CarId = 1, ColorId = 1, BrandId = 1, ModelYear = new DateTime(1987, 01, 01), DailyPrice = 70, Description = "Renault 1987" });
          
            GetList(carManager.GetAll());
            
            carManager.Update(new Car { CarId = 2, ColorId = 2, BrandId = 2, ModelYear = new DateTime(2013, 02, 24), DailyPrice = 100, Description = "Ford Focus" });
            
            GetList(carManager.GetAll());

           
            carManager.Add(new Car { CarId = 5, ColorId = 4, BrandId = 3, ModelYear = new DateTime(2016, 06, 27), DailyPrice = 180, Description = "Audi A3" });
            
            GetList(carManager.GetAll());
            
            GetList(carManager.GetByColorId(2));
           
            GetList(carManager.GetByBrandId(3));

        }
        static void GetList(List<Car> cars)
        {
            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("CarId \t DailyPrice \t Model Year \t Description");

            Console.WriteLine("----- \t -----------  \t ------------  \t --------------- \t ");

            foreach (var car in cars)
            {
                Console.WriteLine("{0} \t {1} \t\t {2} \t {3}", car.CarId, car.DailyPrice, car.ModelYear.ToShortDateString(), car.Description);
            }
        }

        static void GetItem(Car car)
        {
            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("CarId \t DailyPrice \t Model Year \t Description");

            Console.WriteLine("----- \t -----------  \t ------------  \t --------------- \t ");

            Console.WriteLine("{0} \t {1} \t\t {2} \t {3}", car.CarId, car.DailyPrice, car.ModelYear.ToShortDateString(), car.Description);

        }
       
    }
}
