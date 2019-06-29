using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Services
{
    public class SearchService : ISearchService
    {
        private readonly IUserOperationDbService _userDbOpService;
        public SearchService(IUserOperationDbService userDbOpService)
        {
            _userDbOpService = userDbOpService;
        }

        public async Task<IEnumerable<Resturant>> GetResturantsByLocation (string location)
        {
            if (!String.IsNullOrEmpty(location))
            {
                var resturantSearchResult = await _userDbOpService.GetDbContext().Resturants.Where(m => m.Location == location).ToListAsync();
                return resturantSearchResult;
            }

            return null;
        }

        public async Task<IEnumerable<Food>> GetFoodResultByName(string foodName, string location)
        {
            if (!String.IsNullOrEmpty(foodName))
            {               
                var foodSearchResult = await _userDbOpService.GetDbContext().Foods
                    .Where(m => m.FoodName.Contains(foodName) && m.Resturant.Location == location).ToListAsync();
                return foodSearchResult;
            }

            return null;

        }
    }
}
