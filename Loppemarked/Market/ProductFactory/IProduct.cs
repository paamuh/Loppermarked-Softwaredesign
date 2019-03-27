using System;
using Fleamarket.Market.Sale;

namespace Fleamarket.Market.ProductFactory
{
    public interface IProduct
    {
        bool Is_sold();
        string GetName();
        string GetSellerName();
        string GetMaterial();
        string GetCondition();
        string DisplayProduct();
    }
}
