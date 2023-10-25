using System;
using System.Security.Cryptography;

namespace BlogApp.Utilities.TokenHelper
{
    public static class RefreshToken
    {
        public static string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(number);
                return Convert.ToBase64String(number);
            }
        }

    }
}
