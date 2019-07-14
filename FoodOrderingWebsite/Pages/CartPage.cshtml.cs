using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
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
        public async Task<IActionResult> OnGet()
        {
            try
            {
                string userEmail= User.FindFirst("Email").Value;
                Cart = await _cartService.GetUserCart(userEmail);
                return Page();
            }
            catch (NullReferenceException)
            {
                return Redirect("~/Identity/Account/Login");
            }
           
        }

        public async Task<IActionResult> OnPostCompleteOrder(string foodBought, decimal totalPrice, string resturantIds)
        {
            var resturant = resturantIds.Split(",");
            var deliveryStatus = new DeliveryStatus()
            {
                FoodBought = foodBought,
                Price = totalPrice,
                EstimatedTimeofArrival = _cartService.GetETA("somelocation", int.Parse(resturant[1])),
                UserName = User.FindFirst("Email").Value,
                DateTimeOrderCompleted = DateTime.Now
        };

            await _cartService.AddToDeliveryStatusDb(deliveryStatus);

            return RedirectToAction("OnGet");
        }
    }
}