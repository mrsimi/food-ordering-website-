using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface IDetailsService
    {
        Task<Resturant> GetOneResturant(int id);
        Task<Food> GetOneFood(int id);
    }
}
