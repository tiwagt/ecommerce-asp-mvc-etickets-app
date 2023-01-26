using etickets.Data.Base;
using etickets.Models;
using etickets.Views;
using Microsoft.AspNetCore.Mvc;

namespace etickets.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMovieRepository movieRepository, ShoppingCart shoppingCart)
        {
            _movieRepository = movieRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart (int id)
        {
            var selectedMovie = _movieRepository.Movies.FirstOrDefault(p => p.Id == id);
            if (selectedMovie != null)
            {
                _shoppingCart.AddToCart(selectedMovie, 1); 
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedMovie = _movieRepository.Movies.FirstOrDefault(p => p.Id == id);
            if(selectedMovie != null)
            {
                _shoppingCart.RemoveFromCart(selectedMovie);
            }
            return RedirectToAction("Index");
        }
        
    }
}
