using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Names
{
    public static class Names
    {
        private static readonly string[] NamesList = new string[] { "Gary", "Brad", "Mason", "Monte", "Senaca", "Doris" };

        public static string GetRandomName()
        {
            Random r = new Random();
            return NamesList[r.Next(0, NamesList.Length-1)];
        }
    }
}
