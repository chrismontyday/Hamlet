using Models.Items;
using Models.Items.Food;
using Models.Population;
using System.Collections.Generic;

namespace Models.Structures
{
    public class Structure : iStructure
    {
        public string Type { get; set; }
        public List<Person> Population { get; set; }
        public List<Item> Inventory { get; set; }
        public List<iFood> FoodInventory { get; set; }
        public short PopulationLimit { get; set; }

        public Structure(Item item, Food food, short PopulationLimit)
        {
            this.Population = new List<Person>();    
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public bool PerformUniversalTasks()
        {
            //Adds person to population if criteria is met. 
            if (FoodInventory.Count > 50 && Population.Count <= PopulationLimit)
            {
                FoodInventory.RemoveRange(0, 45);
                Population.Add(new Person());
            }

            return true;
        }

        public bool PerformTasks()
        {
            return true;
        }
    }
}
