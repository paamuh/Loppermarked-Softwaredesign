namespace Fleamarket
{
    // Main class to run the program
    // Singleton design pattern
    class Program
    {
    static void Main(string[] args)
        {         
            Client.StartMarked();

            Client.Exit();
        }        
    }
}
