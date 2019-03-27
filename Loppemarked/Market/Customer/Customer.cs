using System;
using System.Collections.Generic;
using Fleamarket.Market.ProductFactory;

namespace Fleamarket.Market.Customer
{
    public class Customer : ICustomer
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
        private string _itemName { get; set; }
        private string _sellerName { get; set; }
        public List<IProduct> ItemsPurchased { get; set; }

        public Customer(string name)
        {
            _name = name;
            ItemsPurchased = new List<IProduct>();
            Console.WriteLine("Customer: {0}", _name);
        }
        
        public void PurchaseItem()
        {            
            MarketPlaceFacade.Instance.Transaction(this);
        }

        public string GetName()
        {
            return _name;
        }

  

        public List<IProduct> GetItems()
        {
            return ItemsPurchased;
        }

        public string GetItemName()
        {
            return _itemName;
        }

        public void AddItems(IProduct product)
        {
            ItemsPurchased.Add(product);
            _itemName = product.GetName();
            _sellerName = product.GetSellerName();
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

        public void AddTotalItems()
        {
            _nrOfItems++;
        }
    }
}
