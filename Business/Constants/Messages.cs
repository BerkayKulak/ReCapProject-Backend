using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    // mesaj yazcaksak newlemicez
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";

        public static string CarNameInvalid = "Geçersiz araç";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarsListed = "Araçlar listelendi";

        public static string Deleted = "Silindi";

        public static string Updated = "Güncellendi";

        public static string Added = "Eklendi";

        public static string Listed = "Listelendi";

        public static string CarRented = "Araç kiralandı";

        public static string CarNotReturned = "Araç dönmedi";

        public static string CarReturned = "Araç döndü";

        public static string CarCountError = "Araç en fazla 10 tane olabilir";

        public static string CarNameAlreadyExist = "Bu isimde zaten başka bir araç var";

        public static string CarImageCountLimitExceeded = "5 tane arabadan fazla yükleyemezsin";

        public  static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin ="Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Access Token oluturuldu";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserUpdate = "Kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string ImageAdded = "resmim eklendi";
        public static string ImageDeleted = "resmim silindi";
        public static string ImagesListed = "resmim listelendi";
        public static string ImageUpdated = "resmim güncellendi";
        public static string CarImageLimitExceeded = "resmim eklendi";
        internal static string Success;

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageNameInvalid = "Araba resmi ismi geçersiz";
        public static string CarImagesListed = "Araba resmi listelendi";
        public static string CarImageCountOfCarError = "Bir aracın en fazla 5 resmi olabilir";
       
        public static string ImageNotFound = "Image not found";
     
        public static string NoResultForThisFilter = "Bu filtre için sonuç dönmedi";
    }
}
