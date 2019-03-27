using System;
using Fleamarket.Market.ProductFactory;
using Fleamarket.Market.Sale;
using Fleamarket.Market.Controller;
using Fleamarket;

namespace Fleamarket.Market.Controller
{
    public class PrintHandler
    {
        
        public PrintHandler()
        {
        }

        public void PrintWelcomeText(){
            PrintSpacing();
            Console.WriteLine("Welcome to Lotta's Flea market");
            PrintSpacing();
        }
       
        public void PrintSpacing(){
            Console.WriteLine("----------------------------------\n");
        }

        public void CloseMarket(){
            PrintSpacing();
            Console.WriteLine("All inventory has been sold.");
            PrintSpacing();
            Console.WriteLine("Lotta's Flea Market is closed for today!");
        }

        public void PrintOpenMarket(){
            PrintSpacing();
            Console.WriteLine("\nToday's Flea Market sellers: \n");
        }

        public void PrintStatistics(){
            Console.WriteLine("\n________________________________________________________________");
            Console.WriteLine("\nTransactions Receipt:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sellers:");
        }
    }
}
