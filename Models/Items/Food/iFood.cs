using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Items.Food
{
    public interface iFood : iItem
    {
        public int Nutrition { get; set; }
    }
}
