using System;
using System.Collections.Generic;
using System.Text;

namespace Council.Elders
{
    public class Elder : iElder
    {
        public string Name { get; set; }

        public void PerformDuties()
        {
            throw new NotImplementedException();
        }
    }
}
