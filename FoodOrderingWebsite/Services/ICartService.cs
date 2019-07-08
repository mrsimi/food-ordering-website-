using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface ICartService
    {
        Task AddToCart(Cart cartItem);
        Task<List<Cart>> GetUserCart(string userName);
        int GetETA(string userLocation, int resturantId);
        Task AddToDeliveryStatusDb(DeliveryStatus deliveryStatus);
    }
}
