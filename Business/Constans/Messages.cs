using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    //Constans:Sabitler
    public static class Messages //static olunca çağırma işleminde new'lememiz gerekmez
    {
		internal static readonly string CategoryNameAlreadyExists;
		public static string AuthorizationDenied="Yetkiniz yoktur";
        public static string ProductAddes = "Ürün Eklendi";
        public static string ProdutNameInvalid = "Ürün ismi geçersiz"; //publicler camelCase 'e uymalıdır , private ise küçük harf ile yazılır
        public static string MaintenanceTime = "Sistemde bakım yapılıyor, Saat 22.00-00.00";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde başka bir ürün var";
        public static string CategoryLimitExceded="Category Limiti Aşıldı";
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

		public static string CategoryAdded = "Kategori başarıyla eklendi";
		// Yeni bir kategori başarıyla eklendiğinde döndürülen bilgilendirme mesajıdır.

		public static string CategoryNotFound = "Kategori bulunamadı";
		// Aranan kategori sistemde bulunamadığında verilen hata mesajıdır.

		public static string CategoryHasSubCategories = "Alt kategorilere sahip bir kategori silinemez.";
		// Silinmek istenen bir kategorinin alt kategorileri bulunduğunda verilen hata mesajıdır.

		public static string CategoryDeleted = "Kategori başarıyla silindi.";
		// Bir kategori başarıyla silindiğinde döndürülen bilgilendirme mesajıdır.

		public static string CategoriesListed = "Kategoriler başarıyla listelendi.";
		// Tüm kategoriler başarıyla listelendiğinde döndürülen bilgilendirme mesajıdır.

		public static string CategoryListed = "Kategori başarıyla getirildi.";
		// Tek bir kategori başarıyla getirildiğinde döndürülen bilgilendirme mesajıdır.

		public static string SubCategoriesListed = "Alt kategoriler başarıyla listelendi.";
		// Bir kategorinin alt kategorileri başarıyla listelendiğinde döndürülen bilgilendirme mesajıdır.

		public static string CategoryUpdated = "Kategori başarıyla güncellendi.";
		// Bir kategori başarıyla güncellendiğinde döndürülen bilgilendirme mesajıdır.
	}
}
