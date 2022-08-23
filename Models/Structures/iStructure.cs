using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures
{
    public interface iStructure
    {
        public List<Person> Population { get; set; }
        public List<Item> Inventory { get; set; }
        public List<iFood> FoodInventory { get; set; }

        public bool PerformUniversalTasks();

        public bool PerformTasks();
    }
}
