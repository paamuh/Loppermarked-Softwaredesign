using Fleamarket.Market.Controller;

namespace Fleamarket.Market.ProductFactory
{
    public class ProductFactory
    {
        private static IProduct product { get; set; }        

        public static IProduct CreateProduct(int numberOfProducts, string sellername)
        {

            for (var i = 0; i < numberOfProducts; i++){
                 var categoryNumber = Client.rnd.Next(5);

                 switch (categoryNumber)
                 {
                    case 0:
                        product = new Garden(sellername);
                        break;
                    case 1:
                        product = new Kitchen(sellername);
                        break;

                    case 2:
                        product = new LivingRoom(sellername);
                        break;

                    case 3:
                        product = new Miscellaneous(sellername);
                        break;

                    case 4:
                        product = new Wearable(sellername);
                        break;

                    default:
                        break;
                }
            }
            return product;
        }
    }

    public class ProductSkeleton : IProduct
    {
        public string Item { get; set; }
        public string Condition { get; set; }
        public string Materials { get; set; }
        public string Seller { get; set; }
        public bool Available { get; set; }
        public ProductSkeleton(IProduct product)
        {
            Item = product.GetName();
            Condition = product.GetCondition();
            Materials = product.GetMaterial();
            Seller = product.GetSellerName();
            Available = product.Is_sold();
        }

        public bool Is_sold()
        {
            return Available;
        }

        public string GetName()
        {
            return Item;
        }

        public string GetSellerName()
        {
            return Seller;
        }

        public string GetMaterial()
        {
            return Materials;
        }

        public string GetCondition()
        {
            return Condition;
        }

        public string DisplayProduct()
        {
            return Item + " for sale!\nCondition: " + Condition + "\nMaterials: " + Materials;
        }
    }
}
