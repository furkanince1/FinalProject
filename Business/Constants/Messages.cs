using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda!";
        public static string ProductListed = "Ürünler Listelendi!";
        public static string ProductCountOfCategoryError = "Kategori dolu";
        public static string ProductNameAlreadyExists = "Bu İsimde zaten başka bir ürün var!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
