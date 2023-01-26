using etickets.Models;


namespace etickets.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _appDbContext;

        private MovieService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static MovieService GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new MovieService(context) { ShoppingCartId = cartId };
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public void AddToCart(Movie movie, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.movie.Id == movie.Id && s.ShoppingCartId == ShoppingCartId
                );

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    movie = movie,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.movie.Price * c.Amount).Sum();

            return (decimal)total;
        }

        public int RemoveFromCart(Movie movie)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.movie.Id == movie.Id && s.ShoppingCartId == ShoppingCartId
                );
            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }
    }
}
