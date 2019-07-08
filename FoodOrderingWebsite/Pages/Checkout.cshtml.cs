using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodOrderingWebsite.Pages
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart { get; set; }
        public void OnPost(int Id, string foodName, decimal foodPrice, string resturantName)
        {
            Cart = new Cart()
            {
                FoodName = foodName,
                FoodPrice = foodPrice,
                ResturantName = resturantName,
                UserName = "Simi"
            };

        }
    }
}