namespace IMRWebAPIApp.Models
{
    public interface IOfferSerice
    {
        List<Product> GetAllProducts();

        List<Product> GetTodayOffers();
    }
}
