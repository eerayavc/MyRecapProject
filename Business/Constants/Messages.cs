using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araçlar eklendi";
        public static string CarAddedInvalid = "Araçlar eklenemedi";
       
        public static string CarDeleted = "Araçlar silindi";
        //public static string CarDeletedInvalid= "Araçlar silinemedi";

        public static string CarUpdated = "Araçlar güncellendi";
        //public static string CarUpdatedInvalid = "Araçlar güncellenemedi";

        //*****************************
        public static string BrandAdded = "Marka bilgisi eklendi";
        public static string BrandAddedInvalid = "Marka bilgisi eklenemedi.Marka uzunluğu en az iki karakter olmalıdır";

        public static string BrandDeleted = "Marka bilgisi silindi";
        //public static string BrandDeletedInvalid = "Marka bilgisi silinemedi";

        public static string BrandUpdated = "Marka bilgisi güncellendi";
        public static string BrandUpdatedInvalid = "Marka bilgisi güncellenemedi";

        //*******************************
        public static string ColorAdd = "Renk bilgisi eklendi";
        public static string ColorAddedInvalid = "Renk bilgisi eklenemedi";

        public static string ColorDeleted = "Renk bilgisi silindi";
        //public static string ColorDeletedInvalid = "Renk bilgisi silinemedi";

        public static string ColorUpdated = "Renk bilgisi güncellendi";
        //public static string ColorUpdatedInvalid = "Renk bilgisi güncellenemedi";

        //********************************** List
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string BrandsListed = "Marka bilgileri listelendi";
        public static string ColorsListed = "Renk bilgileri listelendi";
        


        //*********************************
        public static string CustomerAdded = "Müşteri bilgisi eklendi";
        public static string CustomerUpdated = "Müşteri bilgisi güncellendi";
        public static string CustomerDeleted = "Müşteri bilgisi silindi";

        public static string UserAdded = "Kullanıcı bilgisi eklendi";
        public static string UserUpdated = "Kullanıcı  bilgisi güncellendi";
        public static string UserDeleted = "Kullanıcı bilgisi silindi";

        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedInValid = "Aracın kiralanabilmesi için önce teslim edilmesi gerekir";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi.";
        public static string RentalDeleted = "Kiralama bilgisi silindi.";
        public static string RentalUpdatedReturnDate = "Araç teslim alındı.";
        public static string RentalUpdatedReturnDateInValid= "Araç zaten teslim Alınmış.";








    }
}
