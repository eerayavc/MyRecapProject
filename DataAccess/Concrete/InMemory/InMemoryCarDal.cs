using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=100,Description="PEUGEOT-SİYAH-3008" },
                new Car{CarId = 2,BrandId=2,ColorId=1,ModelYear=2001,DailyPrice=200,Description="MERCEDES-SİYAH-200" },
                new Car{CarId = 3,BrandId=1,ColorId=2,ModelYear=2005,DailyPrice=300,Description="PEUGEOT-KIRMIZI-2008" },
                new Car{CarId = 4,BrandId=3,ColorId=2,ModelYear=2010,DailyPrice=400,Description="BMW-KIRMIZI-CABRİO" },
                new Car{CarId = 5,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=500,Description="MERCEDES-BEYAZ-250" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);//genellikle ıd olduğu zaman singleordefault kullanılır
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId && c.BrandId > 2).ToList();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
