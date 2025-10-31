using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.UserBL
{
    public static class ClsSecureHelperUserInfo
    {
        public static byte[] GenerateSalt(int size = 16)
        {
            using (var rang = RandomNumberGenerator.Create())
            {
                var salt = new byte[size];
                rang.GetBytes(salt);
                return salt;
            }
        }

        public static string HashPassword(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                var hash = pbkdf2.GetBytes(32);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string entertedPassword, string storedHashPassword, byte[] SortedSalt)
        {
            if (string.IsNullOrEmpty(entertedPassword) || string.IsNullOrEmpty(storedHashPassword) || SortedSalt == null || SortedSalt.Length == 0)
            {
                return false;
            }
            
            var hashedPassword = HashPassword(entertedPassword, SortedSalt);
            
            return string.Equals(hashedPassword, storedHashPassword, StringComparison.Ordinal);
        }
    }
}
