using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures.FoodProducer
{
    public class Bakery : Structure
    {
        private int numOfGrainsForBread = 5;

        public Bakery(Item item, Food food, short PopulationLimit) : base (item, food, PopulationLimit)
        {
            this.Type = "Bakery";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public Bakery(Person person, Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Bakery";
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
            foreach(Person p in Population)
            {
                BakeBread();

            }

            return true;
        }

        private Food BakeBread()
        {
            List<iFood> grains = new List<iFood>();
            List<string> Keys = new List<string>();
            int count = 0;
            bool breadBaked = false;

            foreach(Food f in FoodInventory)
            {
                if (f.Name.ToUpper().Equals("Grain") )
                {
                    Keys.Add(f.Key);
                    count++;
                }

                if(count >= numOfGrainsForBread)
                {
                    breadBaked = true;
                    break;
                }
            }

            foreach(string s in Keys)
            {
                FoodInventory.RemoveAll(x => x.Key == s);
            }
        }
    }
}
