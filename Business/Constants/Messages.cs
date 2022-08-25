using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi en az 2 karakter olmalıdır!";
        public static string ProductUnitPriceInvalid = "Ürün İsmi en az 2 karakter olmalıdır!";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductListed = "Ürünler Listelendi";
        public static string MaintenceTime = "Sistem Bakımda";
        public static string ProductNameAlreadyExists = "Aynı Ürün Adına Sahip Bir Ürün Mevcut";
        public static string ProductCountOfCategoryError = "Kategoriye Ürün Ekleme Sınırı Aşıldı";
        public static string CategoryLimitExceded = "Kategori maksimum sayısını aştı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
