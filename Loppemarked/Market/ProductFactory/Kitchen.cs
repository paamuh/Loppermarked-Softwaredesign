namespace Fleamarket.Market.ProductFactory
{
    public class Kitchen : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
        private string _sellername;

        public Kitchen(string sellername){
            RandomKitchenProduct(sellername);
        }

        public void RandomKitchenProduct(string sellername)
        {
            var randomProduct = Client.rnd.Next(4);
            SetSellerName(sellername);
            switch (randomProduct)
            {
                case 0:
                    SetName("Mixmaster");
                    SetCondition("Well used");
                    SetMaterial("Plastic and iron");
                    break;
                case 1:
                    SetName("Cutlery set");
                    SetCondition("Used");
                    SetMaterial("Silverware");
                    break;
                case 2:
                    SetName("Stainless steel pan");
                    SetCondition("New");
                    SetMaterial("Steel");
                    break;
                case 3:
                    SetName("Beer glass");
                    SetCondition("Used");
                    SetMaterial("Glass");
                    break;
                default:
                    SetName("No product");
                    SetCondition("0");
                    SetMaterial("0");
                    break;
            }
        }
        public string GetCondition()
        {
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetSellerName(string name)
        {
            _sellername = name;
        }

        public string GetSellerName()
        {
            return _sellername;
        }

        public string GetMaterial()
        {
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
            return true;
        }

        public string DisplayProduct()
        {
            return _name + "\nCondition: " + _condition + "\nMaterials: " + _material;
        }
    }
}