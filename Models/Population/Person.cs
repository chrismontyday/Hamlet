using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Population
{
    public class Person : iPerson
    {
        public string Name { get; set; }
        public int SleepTime { get; set; }
        public bool isAwake { get; set; }
        public string Key { get; set; }
        public int Money { get; set; }

        public Person()
        {
            Key = DataManagement.DataUtility.CreateSerialID();
            SleepTime = 10;
            Name = PersonUtility.CreateName();
            isAwake = true;
        }

    }
}
