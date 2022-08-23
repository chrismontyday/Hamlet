using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures.Government
{
    public class Garrison : Structure
    {
        public List<Person> Army { get; set; }

        public Garrison(List<Person> Army, Item item, Food food, short PopulationLimit) : base (item, food, PopulationLimit)
        {
            this.Army = Army;
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public new bool PerformTasks()
        {
            return true;
        }
    }
}
