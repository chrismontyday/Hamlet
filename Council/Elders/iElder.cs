using System;
using System.Collections.Generic;
using System.Text;

namespace Council.Elders
{
    interface iElder
    {
        public String Name { get; set; }

        public void PerformDuties();
    }
}
