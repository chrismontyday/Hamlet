using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items
{
    public interface iItem
    {
        public String Name { get; set; }
        public String Key { get; set; }
    }
}
