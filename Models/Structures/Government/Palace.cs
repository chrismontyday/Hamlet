using System;
using System.Collections.Generic;
using System.Text;
using Models.Items;
using Models.Items.Food;
using Models.Population;

namespace Models.Structures.Government
{
    public class Palace : Garrison
    {
        public Palace(List<Person> Army, Item item, Food food, short PopulationLimit) : base(Army, item, food, PopulationLimit)
        {
            this.Type = "Palace";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public Palace(List<Person> Army, Person person, Item item, Food food, short PopulationLimit) : base(Army, item, food, PopulationLimit)
        {
            this.Army = Army;
            this.Type = "Palace";
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
