using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Market
    {     
        Seller slrr = new Seller();
        public Market()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Lotta's Loppemarked");
            Console.WriteLine("--------------------------");
            slrr.showProducts();
        }
    }
}
