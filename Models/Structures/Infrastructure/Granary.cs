using Models.Items;
using Models.Items.Food;
using Models.Population;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Structures.Infrastructure
{
    public class Granary : Structure
    {
        private int numberOfGrainsAdded = 50;
        private int maxGrainToTake = 10;

        public Granary(Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Granary";
            this.Population = new List<Person>();
            this.Inventory = new List<Item>();
            this.FoodInventory = new List<iFood>();
            this.PopulationLimit = PopulationLimit;

            Inventory.Add(item);
            FoodInventory.Add(food);
        }

        public Granary(Person person, Item item, Food food, short PopulationLimit) : base(item, food, PopulationLimit)
        {
            this.Type = "Granary";
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
                AddGrain(numberOfGrainsAdded);
            }

            return true;
        }

        private void AddGrain(int amountOfGrain)
        {
            for(int i = 0; i < amountOfGrain; i++)
            {
                FoodInventory.Add(new Food("Grain"));
            }
        }

        public List<iFood> GetGrain(int num)
        {
            List<iFood> grains = new List<iFood>(); 

            if (num > maxGrainToTake)
            {
                num = maxGrainToTake;
            }

            if (num >= FoodInventory.Count)
            {
                num = FoodInventory.Count;
            }

            FoodInventory.RemoveRange(0, num);
            
            for(int i = 0; i < num; i++)
            {
                grains.Add(new Food("Grain"));
            }

            return grains;
        }
    }
}
