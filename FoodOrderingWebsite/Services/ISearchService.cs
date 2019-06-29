using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<Resturant>> GetResturantsByLocation  (string location);
        Task<IEnumerable<Food>> GetFoodResultByName(string foodName, string location);
    }
}
