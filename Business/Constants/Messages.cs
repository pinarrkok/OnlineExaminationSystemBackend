using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";

        public static string StudentAdded = "Öğrenci başarıyla eklendi.";
        public static string StudentDeleted = "Öğrenci başarıyla silindi.";
        public static string StudentUpdated = "Öğrenci başarıyla güncellendi.";

        public static string ExamAdded = "Sınav başarıyla eklendi.";
        public static string ExamDeleted = "Sınav başarıyla silindi.";
        public static string ExamUpdated = "Sınav başarıyla güncellendi.";
        public static string ExamAlreadyExists = "Bu sınav zaten eklendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
