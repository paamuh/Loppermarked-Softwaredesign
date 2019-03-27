using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Item
    {
        public string itemName { get; set; }
        public string itemCondition { get; set; }
        public Boolean isSold { get; set; }
        public string sellerName { get; set; }

        public Item(string name, string condition, string sellername)
        {
            
            itemName = name;
            itemCondition = condition;
            isSold = false;
            sellerName = sellername;
        }
    }
}
