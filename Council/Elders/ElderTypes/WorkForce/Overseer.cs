using Models.Population;
using Models.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Council.Elders.ElderTypes.WorkForce
{
    public class Overseer : Elder
    {
        public Overseer(string name)
        {
            this.Name = name;
        }

        public List<iStructure> DriveWork(List<iStructure> buildings)
        {
            foreach(Structure building in buildings)
            {
                building.PerformUniversalTasks();
            }

            return buildings;
        }
    }
}
