namespace Fleamarket.Market.ProductFactory
{
    public class Garden : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
        private string _sellername;

        public Garden(string sellername){
            RandomGardenProduct(sellername);
        }

        public void RandomGardenProduct(string sellername)
        {
            var randomProduct = Client.rnd.Next(4);
            SetSellerName(sellername);

            switch (randomProduct)
            {
                case 0:
                    SetName("Bosch lawnmower");
                    SetCondition("Well used");
                    SetMaterial("");
                    
                    break;
                case 1:
                    SetName("Gardena water hose");
                    SetCondition("Slightly used");
                    SetMaterial("Plastic");
                    break;
                case 2:
                    SetName("Brown pot");
                    SetCondition("New");
                    SetMaterial("Clay");
                    break;
                case 3:
                    SetName("Garden chair");
                    SetCondition("used");
                    SetMaterial("Plastic");
                    break;
                default:
                    SetName("No product");
                    SetCondition("0");
                    SetMaterial("0");
                    break;
            }
        }

        public string GetCondition(){
            return _condition;
        }

        public void SetCondition(string condition){
            _condition = condition;
        }

        public string GetName(){
            return _name;
        }

        public void SetSellerName(string name)
        {
            _sellername = name;
        }

        public string GetSellerName()
        {
            return _sellername;
        }

        public void SetName(string name){
            _name = name;
        }

        public string GetMaterial(){
            return _material;
        }

        public void SetMaterial(string material){
            _material = material;
        }

        public bool Is_sold(){
            return true;
        }

        public string DisplayProduct()
        {
            return _name + "\nCondition: " + _condition + "\nMaterials: " + _material;
        }
    }
        
}
