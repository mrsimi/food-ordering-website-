using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodOrderingWebsite.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IDetailsService _detailsService;
        private readonly ICartService _cartService;

   
        public Resturant Resturant { get; set; }


        public DetailsModel(IDetailsService detailsService, ICartService cartService)
        {
            _detailsService = detailsService;
            _cartService = cartService;
        }
        public async Task<IActionResult> OnGetAsync(int? id, string sender)
        {
            if (id == null)
            {
                return NotFound();
            }
            else if (String.Equals(sender, "resturant"))
            {
                Resturant = await _detailsService.GetOneResturant((int)id);
                if (Resturant == null)
                {
                    return NotFound();
                }
            }

            return Page();
            
        }

        public async Task<IActionResult> OnPostOrders(int Id, string foodName, decimal foodPrice, string resturantName)
        {
            var foodInfo = new Cart()
            {
                FoodName = foodName,                
                FoodPrice = foodPrice,
                ResturantName = resturantName,
                UserName = "simi",
                ResturantId = Id
            };

            await _cartService.AddToCart(foodInfo);
            

            return await OnGetAsync(Id, "resturant");
        }
    }
}