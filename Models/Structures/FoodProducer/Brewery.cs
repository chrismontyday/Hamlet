using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures.FoodProducer
{
    public class Brewery : Structure
    {
        public Brewery(Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Brewery";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public Brewery(Person person, Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Brewery";
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
