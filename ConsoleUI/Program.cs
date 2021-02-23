using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //LİST();

        }

        //private static void LİST()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    //ColorManager colorManager = new ColorManager(new EfColorDal());
        //    Console.WriteLine("------GÜNLÜK ARAÇ KİRA FİYATLARI------");
        //    Console.WriteLine("---------------------------------------------");
        //    Console.WriteLine("Marka Id     Renk Id      Model Yılı       Açıklama        Günlük ücret");
        //    Console.WriteLine("--------     -------      ----------       --------        ------------");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.BrandId + "      -      " + car.ColorId + "     -       " + car.ModelYear + "      -     " + car.Description + "     ---> " + car.DailyPrice + " TL");
        //    }

        //    Console.WriteLine("------ARAÇ MARKA ID VE MARKA ADI BİLGİSİ------");
        //    Console.WriteLine("---------------------------------------------");
        //    Console.WriteLine("Marka Id     Marka Adı");
        //    Console.WriteLine("--------     ---------");
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandId + "       --->  " + brand.BrandName);
        //    }

        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    Console.WriteLine("------ARAÇ RENK ID VE MARKA ADI BİLGİSİ------");
        //    Console.WriteLine("---------------------------------------------");
        //    Console.WriteLine("Renk Id     Renk Adı");
        //    Console.WriteLine("-------     --------");
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorId + "       --->  " + color.ColorName);
        //    }

        //    Console.ReadKey();
        //}
        //*******************************************************************************
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success ==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

    }
}
