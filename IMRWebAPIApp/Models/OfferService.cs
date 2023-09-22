namespace IMRWebAPIApp.Models
{
    public class OfferService : IOfferSerice
    {
        private List<Product> Inventory()
        {
            List<Product> productsList = new List<Product>()
            {
                new Product("P1", 1000, "P1 Desc"),
                new Product("P2", 200, "P2 Desc"),
                new Product("P3", 400, "P3 Desc"),
                new Product("P4", 700, "P4 Desc"),
                new Product("P5", 600, "P5 Desc"),
                new Product("P6", 800, "P6 Desc"),
            };


            return productsList;
        }

        public List<Product> GetAllProducts() { 
            return Inventory();
        }

        public List<Product> GetTodayOffers() { 
            var random = new Random();
            int index = random.Next(3);

            List<Product> products = Inventory();

            var packages = products[index];

            return products;
        }
    }
}
