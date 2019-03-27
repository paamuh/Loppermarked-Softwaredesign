using System;
using Fleamarket.Market;
using Fleamarket.Market.Controller;

namespace Fleamarket
{
     public static class Client
    {
        public static readonly Random rnd = new Random();

        public static void StartMarked()
        {
            PrintHandler printer = new PrintHandler();
            printer.PrintWelcomeText();
            MarketPlaceFacade.Instance.Create();
            Console.WriteLine("\nPress enter to start");

            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            MarketPlaceFacade.Instance.Open();
        }
        public static void Exit()
        {
            Console.WriteLine("Press space to exit flea market");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
            Environment.Exit(0);
        }

    }
}
