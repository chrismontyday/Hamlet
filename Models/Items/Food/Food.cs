using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items.Food
{
    public class Food : iFood
    {
        public int Nutrition { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public short Quality { get; set; }

        public Food(string Name = "Bread", short Quality = 1)
        {
            this.Name = Name;
            this.Quality = Quality;
            this.Key = DataManagement.DataUtility.CreateSerialID();
        }
    }
}
