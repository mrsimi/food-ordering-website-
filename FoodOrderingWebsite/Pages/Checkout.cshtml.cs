﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodOrderingWebsite.Pages
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart { get; set; }
        public int resturant { get; set; }
        private readonly ICartService _cartService;

        public CheckoutModel(ICartService cartService)
        {
            _cartService = cartService;
        }
        public void OnPost(int Id, string foodName, decimal foodPrice, string resturantName, int resturantId)
        {
            Cart = new Cart()
            {
                FoodName = foodName,
                FoodPrice = foodPrice,
                ResturantName = resturantName,
                UserName = "Simi"
            };

            resturant = resturantId;

        }

        public async Task OnPostCompleteOrder(string foodBought, decimal totalPrice, int resturantId, string resturantName)
        {
            var deliveryStatus = new DeliveryStatus()
            {
                FoodBought = foodBought,
                Price = totalPrice,
                EstimatedTimeofArrival = _cartService.GetETA("somelocation", resturantId),
                UserName = "simi"
            };

            await _cartService.AddToDeliveryStatusDb(deliveryStatus);

            OnPost(0,foodBought, totalPrice,resturantName, resturantId);
        }
    }
}