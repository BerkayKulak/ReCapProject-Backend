using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string CarAdded = "Araç başarı ile eklendi";
        public static string CarPriceInvalid = "Ekleme başarısız : Araba günlük fiyatı 0 TL üzerinde olmalıdır";
        public static string MaintenanceTime = "Sistem bakımdadır";

        public static string CarListed = "Araçlar listelendi";
        public static string CarDeleted = "Araç başarı ile silindi";
        public static string CarUpdated = "Araç başarı ile güncellendi";
        public static string CarUpdateInvalid = "Güncelleme başarısız : Araba günlük fiyatı 0 TL üzerinde olmalıdır";
        public static string CarDetailDtoMessage = "Araba detayları başarı ile getirildi";
        public static string CarNameInvalid = "Ekleme başarısız : Araba ismi 2 karakterden uzun olmalıdır";

        public static string BrandAdded = "Marka başarı ile eklendi";
        public static string BrandDeleted = "Marka başarı ile silindi";
        public static string BrandUpdated = "Marka başarı ile güncellendi";
        public static string BrandNameInvalid = "Ekleme başarısız : Marka ismi 2 karakterden uzun olmalıdır";
        public static string BrandUpdateInvalid = "Güncelleme başarısız : Marka ismi 2 karakterden uzun olmalıdır";

        public static string ColorAdded = "Renk başarı ile eklendi";
        public static string ColorDeleted = "Renk başarı ile silindi";
        public static string ColorUpdated = "Renk başarı ile güncellendi";

        public static string CustomerAdded = "Müşteri başarı ile eklendi";
        public static string CustomerDeleted = "Müşteri başarı ile silindi";
        public static string CustomerUpdated = "Müşteri başarı ile güncellendi";

        public static string UserAdded = "Kullanıcı başarı ile eklendi";
        public static string UserDeleted = "Kullanıcı başarı ile silindi";
        public static string UserUpdated = "Kullanıcı başarı ile güncellendi";

        public static string RentalAdded = "Kiralama bilgisi başarı ile eklendi";
        public static string RentalError = "Araç şu anda kiralanamaz";
        public static string RentalDeleted = "Kiralama bilgisi başarı ile silindi";
        public static string RentalUpdated = "Kiralama bilgisi başarı ile güncellendi";
        public static string ErrorRentalUpdate = "Araç şu anda kirada değil, sonlandırma başarısız";
        public static string SuccessRentalUpdate = "Kiralama başarı ile sonlandırıldı";

        public static string ImageAdded = "Resim başarı ile eklendi";
        public static string ImageDeleted = "Resim başarı ile silindi";
        public static string ImageUpdated = "Resim başarı ile güncelledi";

        public static string CountOfImageLimitError = "Bir araca ait en fazla 5 resim eklenebilir";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kullanıcı kaydoldu ";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string AccessTokenCreated = "Kayıt Oluşturuldu";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";

        public static string creditCardAdded = "Kredi kartı başarı ile eklendi";

        public static string creditCardDeleted = "Kredi kartı başarı ile silindi";
        public static string findeksScoreAdded = "Findeks skorunuz başarı ile eklendi";
        public static string findeksScoreDelete = "Findeks skorunuz başarı ile silindi";
        public static string findeksScoreUpdate = "Findeks skorunuz başarı ile güncellendi";

        public static string CarIsNotAvailable { get; internal set; }
    }
}