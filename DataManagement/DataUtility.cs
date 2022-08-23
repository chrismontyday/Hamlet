using System;
using System.Security.Cryptography;

namespace DataManagement
{
    public static class DataUtility
    {
        public static string CreateSerialID()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] apiKey = new byte[32];
            rng.GetBytes(apiKey);
            string s = System.Convert.ToBase64String(apiKey);
            return s;
        }
    }
}
