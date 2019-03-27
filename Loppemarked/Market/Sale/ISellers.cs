using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fleamarket.Market.Customer;
using Fleamarket.Market.ProductFactory;

namespace Fleamarket.Market.Sale
{
    public interface ISellers
    {
        string GetName();
        void AddProduct();
        void Sell(Customer.Customer customer);
        bool ProductAvailable();
        bool ItemSold();
    }
}
