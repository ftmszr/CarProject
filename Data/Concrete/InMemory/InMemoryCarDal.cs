using DataAccess.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _car; //kullanılacak araba listesi 
        public InMemoryCarDal() //constructor
        {
            _car = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 30, DailyPrice = 15, Description = "asd", ModelYear = 1990 },
                new Car{CarId = 2, BrandId = 12, ColorId = 3, DailyPrice = 25, Description = "hhg", ModelYear = 1980 },
                new Car{CarId = 3, BrandId = 13, ColorId = 4, DailyPrice = 35, Description = "mnb", ModelYear = 1995 },
                new Car{CarId = 4, BrandId = 14, ColorId = 5, DailyPrice = 45, Description = "oıu", ModelYear = 2000 }
            }; 
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);//linq
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId); //foreach döngüsü yerine ıd aramaları
            carUpdate.BrandId = car.BrandId;  //yenileme adımları
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
