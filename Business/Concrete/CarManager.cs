using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç bilgisi yüklendi.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Araç fiyat bilgisi min 1 olmalıdır.İşlem başarısız!");
                Console.ReadLine();
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç bilgisi silinmiştir");
            Console.ReadLine();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public Car GetByCarId(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araç bilgisi güncellenmiştir");
            Console.ReadLine();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
