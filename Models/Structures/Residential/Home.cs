using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures.Residential
{
    public class Home : Structure
    {
        public Home(Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Home";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public Home(Person person, Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Home";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Population.Add(person);
            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public new bool PerformTasks()
        {
            return true;
        }
    }
}
