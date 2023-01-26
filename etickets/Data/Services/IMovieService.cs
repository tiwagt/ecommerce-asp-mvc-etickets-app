using etickets.Models;

namespace etickets.Data.Services
{
    public interface IMovieService
    {
        void AddToCart(Movie movie, int amount);

        int RemoveFromCart(Movie movie);

        void ClearCart();

        decimal GetShoppingCartTotal();
    }
}
