using etickets.Models;

namespace etickets.Data.Services
{
    public interface IShoppingCart
    {
        void AddToCart(Movie movie, int amount);

        int RemoveFromCart(Movie movie);

        void ClearCart();

        decimal GetShoppingCartTotal();
    }
}
