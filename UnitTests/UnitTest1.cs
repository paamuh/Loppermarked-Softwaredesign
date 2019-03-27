using NUnit.Framework;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Customer;
using Loppemarked.Market.Sale;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateProduct_Garden_CheckNames()
        {
            IProduct product = new Garden("Test1");

            bool result = false;

            string name = product.GetName();
            if (name == "Bosh lawnmower" || name == "Gardena water hose" || name == "Brown pot" || name == "Garden chair")
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.IsTrue(result);

        }
        [Test]
        public void Customer_CreateCustomer_CheckName()
        {
            string expectedName = "Harry";

            Customer result = new Customer("Harry");
            string resultName = result.GetName();

            Assert.AreEqual(expectedName, resultName);


        }

        [Test]
        public void Customer_AddItems_CheckItemInList()
        {
            IProduct Expected = new Garden("Alice");
            Customer TestCostumer = new Customer("Bob");

            TestCostumer.AddItems(Expected);

            IProduct result = TestCostumer.ItemsPurchased[0];

            Assert.AreEqual(Expected, result);
        }

        [Test]
        public void Customer_PurchaseItem()
        {



        }
    }
}