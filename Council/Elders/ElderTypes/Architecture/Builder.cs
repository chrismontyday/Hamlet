
using Models.Items;
using Models.Items.Food;
using Models.Population;
using Models.Structures;
using System.Collections.Generic;
using Models.Structures.FoodProducer;
using Models.Structures.Government;
using Models.Structures.Infrastructure;
using Models.Structures.Residential;

namespace Council.Elders.ElderTypes.Architecture
{
    public class Builder : Elder
    {
        public Builder(string Name)
        {
            this.Name = Name;
        }

        public List<iStructure> ConstructBuildings()
        {
            List<iStructure> buildings = new List<iStructure>();
            List<Person> Army = new List<Person>();

            for(int i = 0; i < 20; i++)
            {
                Army.Add(new Person());
            }

            buildings.Add(new Palace(Army, new Person(), new Item("Thing"), new Food(), 50));
            buildings.Add(new Granary(new Person(), new Item("Thing"), new Food(), 5));
            buildings.Add(new Bakery(new Person(), new Item("Thing"), new Food(), 3));
            buildings.Add(new Brewery(new Person(), new Item("Thing"), new Food(), 3));
            buildings.Add(new Home(new Person(), new Item("Thing"), new Food(), 8));

            return buildings;
        }
    }
}
