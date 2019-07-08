using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Services
{
    public class CartService : ICartService
    {
        private readonly IUserOperationDbService _context; 
        public CartService(IUserOperationDbService context)
        {
            _context = context;
        }
        public async Task AddToCart(Cart cartItem)
        {
             _context.GetDbContext().Carts.Add(cartItem);
            await _context.GetDbContext().SaveChangesAsync();
        }

        public async Task AddToDeliveryStatusDb(DeliveryStatus deliveryStatus)
        {
            _context.GetDbContext().DeliveryStatuses.Add(deliveryStatus);
            await _context.GetDbContext().SaveChangesAsync();
        }

        public int GetETA(string userLocation, int resturantId)
        {
            //calculate ETA based on userLocation and resturant Location
            //more complicated than that
            int handwrittenEta = 45;
            string resturantLocation = _context.GetDbContext().Resturants.FirstOrDefault(m => m.ID == resturantId).Location;
            return handwrittenEta;
        }

        public async Task<List<Cart>> GetUserCart(string userName)
        {
            return await _context.GetDbContext().Carts.Where(m => m.UserName == userName).Distinct().ToListAsync();
        }
    }
}
