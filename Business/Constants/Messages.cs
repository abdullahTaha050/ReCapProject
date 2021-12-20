using Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarılı.";
        public static string Listed = "Listeleme işlemi başarılı.";
        public static string Updated = "Güncelleme işlemi başarılı.";
        public static string Deleted = "Silme işlemi başarılı.";
        public static string CarAdded = "Araç başarıyla eklendi.";
        public static string InvalidCarDetail = "Araç ismi 2 karakterden uzun olmalı ve günlük bedeli 0'dan büyük olmalıdır.";
        public static string InvalidCustomerName = "Şirket adı 2 karakterden uzun olmalıdır.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string BrandNameAlreadyExists = "Aynı modelden iki defa eklenemez.";
        public static string MaximumCarImageLimitExceded = "Maksimum araç fotoğrafı sayısına ulaşıldı";
        public static string ImageAddedMsg = "Fotoğraf eklendi.";
        public static string UserRegistered = "Kullanıcı kaydedildi.";
        public static string UserAlreadyExists = "Kullanıcı sistemde kayıtlı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError="Hatalı parola.";
        public static string AccessTokenCreated = "Access token oluşturuldu.";
        public static string AuthorizationDenied="Yetkisiz giriş.";
    }
}
