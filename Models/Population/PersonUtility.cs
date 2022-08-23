using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Models.Population
{
    public static class PersonUtility
    {
        
        public static string CreateName()
        {
            return DataManagement.Names.Names.GetRandomName();
        }


    }
}
