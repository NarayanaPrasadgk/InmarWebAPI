namespace IMRWebAPIApp.Models
{
    public class Offer
    {
        public string? OfferName { get; set; }

        List<Product> productsList = new List<Product>();

        public Offer(string offerName, List<Product> prdList) {
            OfferName = offerName;
            productsList = prdList;
        }
    }
}
