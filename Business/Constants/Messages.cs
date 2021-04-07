using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // mesaj yazcaksak newlemicez
    public static class Messages
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string CarRent = "0 TL'den düşük kiralanamaz";
        public static string CarUpdated = "Ürün Güncellendi";
        public static string CarDeleted = "Ürün silindi";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string CarListed = "Ürünler Listelendi";
        internal static string ColorDeleted = "Renk silindi";
        internal static string ColorsListed = "Renkler listelendi";
        internal static string ColorAdded = "Renkler Eklendi";
        internal static string ColorUpdated = "Renkler Güncellendi";
        internal static string BrandDeleted = "Marka silindi";
        internal static string BrandsListed = "Markalar listelendi";
        internal static string BrandAdded = "Marka eklendi";
        internal static string BrandUpdated = "Marka güncellendi";
    }
}
