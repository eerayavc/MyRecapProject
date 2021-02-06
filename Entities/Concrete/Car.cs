using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }//brand=marka
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }//günlük ücret
        public string Description { get; set; }//açıklama ör:cillop gibi araba
    }
}
