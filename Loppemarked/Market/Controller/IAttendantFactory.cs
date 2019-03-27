using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fleamarket.Market.Customer;
using Fleamarket.Market.ProductFactory;
using Fleamarket.Market.Sale;

namespace Fleamarket.Market.Controller
{
    interface IAttendantFactory
    {
        ICustomer CreateCustomer(string name);

        ISellers CreateSeller(string name, int total, IProduct product);
    }
}
