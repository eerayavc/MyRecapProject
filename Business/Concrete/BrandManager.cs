using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka bilgisi eklenmiştir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girilen marka ismi uzunluğu minimum üç karakter olmalıdır.İşlem başarısız!");
                Console.ReadLine();
            }

        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka bilgisi silinmiştir");
            Console.ReadLine();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

    
        public Brand GetCarsByBrandId(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Marka bilgisi güncellenmiştir");
            Console.ReadLine();
        }
    }
}
