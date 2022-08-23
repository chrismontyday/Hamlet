using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Population
{
    interface iPerson
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int SleepTime { get; set; }
        public bool isAwake { get; set; }

    }
}
