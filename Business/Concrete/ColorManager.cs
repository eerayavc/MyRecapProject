using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length >3)
            {
                _colorDal.Add(color);
                Console.WriteLine("Renk bilgisi eklenmiştir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Renk bilgisi 3 karakterden fazla olmalıdır.İşlem başarısız!");
                Console.ReadLine();
            }
            
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk bilgisi silinmiştir.");
            Console.ReadLine();

        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetCarsByColorId(int id)
        {
            return _colorDal.Get(c => c.ColorId == id); ;
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk bilgisi güncellenmiştir");
            Console.ReadLine();
        }
    }
}
