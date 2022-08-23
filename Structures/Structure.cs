using Models.Items;
using Models.Items.Food;
using Models.Population;
using Models.Structures;
using System;
using System.Collections.Generic;

namespace Structures
{
    public class Structure : iStructure
    {
        public string Type { get; set; }
        public List<Person> Population { get; set; }
        public List<Item> Inventory { get; set; }
        public List<iFood> FoodInventory { get; set; }

        public Structure(string type, Person person, Item item, Food food)
        {
            Type = type;
            this.Population = new List<Person>();    
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();

            Population.Add(person);
            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public bool PerformTask()
        {
            foreach(Person p in Population)
            {
                if (p.isAwake)
                {
                    //do stuff
                }

            }

            return true;
        }
    }
}
