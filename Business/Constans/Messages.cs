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
        public static string ProductAddes = "Ürün Eklendi";
        public static string ProdutNameInvalid = "Ürün ismi geçersiz"; //publicler camelCase 'e uymalıdır , private ise küçük harf ile yazılır
        public static string MaintenanceTime = "Sistemde bakım yapılıyor, Saat 22.00-00.00";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde başka bir ürün var";
        public static string CategoryLimitExceded="Category Limiti Aşıldı";
    }
}
