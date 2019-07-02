using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Services
{
    public class DetailsService : IDetailsService
    {
        private readonly IUserOperationDbService _context;
        public DetailsService(IUserOperationDbService context)
        {
            _context = context;
        }

        public async Task<Food> GetOneFood(int id)
        {
            return await _context.GetDbContext().Foods.Include(m => m.Resturant).FirstOrDefaultAsync(m => m.ID == id);
        }

        public async Task<Resturant> GetOneResturant(int id)
        {
            return await _context.GetDbContext().Resturants.Include(m => m.Menu).AsNoTracking().FirstOrDefaultAsync(m => m.ID == id);
        }
    }
}
