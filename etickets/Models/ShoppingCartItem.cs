namespace etickets.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Movie movie { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
