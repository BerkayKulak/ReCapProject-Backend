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
    }
}
