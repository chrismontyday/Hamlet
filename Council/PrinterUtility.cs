using Models.Structures;
using System;
using System.Collections.Generic;

namespace Council
{
    public static class PrinterUtility
    {
        public static void Print(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        public static string GetResponse()
        {
            return Console.ReadLine();
        }

        public static void PrintBuildings(List<iStructure> buildings)
        {
            Console.WriteLine($"You have {buildings.Count} buildings.");

            foreach (Structure structure in buildings)
            {
                Console.WriteLine($"A {structure.Type} with a population of {structure.Population.Count}. Food Inventory: {structure.FoodInventory.Count}");
            }
        }

        public static void PrintNews(List<String> listArray)
        {
            if (listArray.Count != 0)
            {
                foreach (string s in listArray)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static int ConvertResponseIntoNumber(string response)
        {
            if (response.Contains("1") || response.ToUpper().Contains("ONE"))
            {
                return 1;
            }
            if (response.Contains("2") || response.ToUpper().Contains("TWO"))
            {
                return 2;
            }
            if (response.Contains("3") || response.ToUpper().Contains("THREE"))
            {
                return 3;
            }
            if (response.Contains("4") || response.ToUpper().Contains("FOUR"))
            {
                return 4;
            }
            if (response.Contains("5") || response.ToUpper().Contains("FIVE"))
            {
                return 5;
            }
            if (response.Contains("6") || response.ToUpper().Contains("SIX"))
            {
                return 6;
            }
            if (response.Contains("7") || response.ToUpper().Contains("SEVEN"))
            {
                return 7;
            }
            if (response.Contains("8") || response.ToUpper().Contains("EIGHT"))
            {
                return 8;
            }
            if (response.Contains("9") || response.ToUpper().Contains("NINE"))
            {
                return 9;
            }

            return 0;
        }
    }
}
