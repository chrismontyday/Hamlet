using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items
{
    public class Item : iItem
    {
        public string Name { get ; set; }
        public string Key { get; set; }

        public Item(string Name)
        {
            this.Name = Name;
            this.Key = DataManagement.DataUtility.CreateSerialID();
        }
    }
}
