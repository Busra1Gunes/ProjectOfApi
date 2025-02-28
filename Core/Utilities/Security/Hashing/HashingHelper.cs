using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //verilen password'ün hash'ini oluşturur
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //ComputeHash metoduna byte bir değişken gönderilmelidir, Encoding.UTF8.GetBytes değişkeni byte türüne dönüştürür
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash,  byte[] passwordSalt) //verilen passwordun bizim veri tabanındaki hash'göre ilgili salt ile eşleşip eşleşilmediğini kontrol eder
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
               var  computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++) 
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
