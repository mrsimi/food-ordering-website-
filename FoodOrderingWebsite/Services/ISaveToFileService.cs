using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface ISaveToFileService
    {
        void AddToFIle(string name, Food foodData);
        List<Food> GetFile(string name);
    }
}
