using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Pages
{
    public class CartPageModel : PageModel
    {
        public IEnumerable<Cart> Cart { get; set; }
        private readonly ICartService _cartService;
     

        public CartPageModel(ICartService cartService)
        {
            _cartService = cartService;
        }
        public async Task OnGet(string userName)
        {
            userName = "simi";
            Cart = await _cartService.GetUserCart(userName);
        }

        public async Task<IActionResult> OnPostCompleteOrder(string foodBought, decimal totalPrice, string resturantIds)
        {
            var resturant = resturantIds.Split(",");
            var deliveryStatus = new DeliveryStatus()
            {
                FoodBought = foodBought,
                Price = totalPrice,
                EstimatedTimeofArrival = _cartService.GetETA("somelocation", int.Parse(resturant[1])),
                UserName = "simi"
            };

            await _cartService.AddToDeliveryStatusDb(deliveryStatus);

            return RedirectToAction("OnGet");
        }
    }
}