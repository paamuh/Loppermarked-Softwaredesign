using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Fleamarket.Market.ProductFactory;
using Fleamarket.Market.Customer;

namespace Fleamarket.Market.Sale
{
    public class Seller : ISellers
    {
        private  string _name { get; set; }
        public string ItemName { get; set; }
        public List<IProduct> Items { get; set; }
        public static int ItemCount { get; set; }
        private int _itemNr { get; set; }
        private IProduct _product;
        private int _nrItems { get; set; }
        private bool _isSold { get; set; }
       
        public Seller(string name, int total, IProduct product)
        {
            _name = name;
            _nrItems = total;
            ItemCount = 0;
            _itemNr = 0;
            Items = new List<IProduct>();
            Console.WriteLine("{0} has come with {1} items {2} to the flea market to trade!", _name, total, product.GetName());
            this._product = product;
            _isSold = false;
        }

        public string GetName()
        {
            return _name;
        }

        public  void AddProduct()
        {
            _isSold = true;
            Console.WriteLine("{0} has come to sell some items!", _name);
            
            for (var i = 0; i < _nrItems; i++)
            {
                    ItemCount++;
                    _itemNr++;
                    Items.Add(new ProductSkeleton(_product));
                    ItemName = Items[0].GetName();
                    Console.WriteLine("{0} has listed a #{1} {2}\n", _name, _itemNr, Items[0].DisplayProduct());
                    Thread.Sleep(500);
            }
            _itemNr = 0;
            Console.WriteLine("{0} has sold out!", _name);
            _isSold = false;

        }

        public void Sell(Customer.Customer customer)
        {
            customer.AddItems(_product);
            string transaction = customer.GetName() + " bought item #" + _itemNr+ " " + customer.GetItemName() + "\nFrom: " + _name + "\n";
            Console.WriteLine(transaction.PadLeft(Console.WindowWidth));
            customer.AddTotalItems();
            Items.RemoveAt(0);
        }        

        public bool ProductAvailable()
        {
            if (Items.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ItemSold()
        {
            return _isSold;
        }
    }
}
