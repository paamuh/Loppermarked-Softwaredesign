using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fleamarket.Market.Customer;
using Fleamarket.Market.ProductFactory;
using Fleamarket.Market.Sale;

namespace Fleamarket.Market.Controller
{
    class AttendantFactory : IAttendantFactory
    {
        public ICustomer CreateCustomer(string name)
        {
            return new Customer.Customer(name);
        }

        public ISellers CreateSeller(string name, int total, IProduct product)
        {
            return new Seller(name,total,product);
        }
    }
}
