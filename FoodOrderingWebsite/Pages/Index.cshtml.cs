using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodOrderingWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISearchService _searchService;
      
        public IndexModel(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public IEnumerable<Resturant> ResturantList { get; set; } 
        public IEnumerable<Food> FoodList { get; set; }
        

        public async Task OnGetAsync()
        {
            //hardcoded location for testing
            string[] resturantsLocation = new string[] { "Akure", "Lagos"};
            Random random = new Random();
            string randomLocation = resturantsLocation[random.Next(resturantsLocation.Count())];

            var resturants = await _searchService.GetResturantsByLocation(randomLocation);
            ResturantList = resturants;

            ViewData["FoodSearch"] = "";
            ViewData["Location"] = randomLocation;
            ViewData["SearchError"] = "";
            
        }

        public async Task OnPostAsync()
        {
            var searchLocation = Request.Form["searchLocationParams"];
            var searchFood = Request.Form["searchFoodParams"];

            //Console.WriteLine($"{searchFood}, {searchLocation} ");
            if (String.IsNullOrEmpty(searchFood))
            {
                var resturantsByLocation = await _searchService.GetResturantsByLocation(searchLocation);
                ResturantList = resturantsByLocation;
                
                ViewData["Location"] = searchLocation;
            }
            else
            {
                var resturantsByFood = await _searchService.GetFoodResultByName(searchFood, searchLocation);
                FoodList = resturantsByFood;
                if (!resturantsByFood.Any())
                {
                    ViewData["SearchError"] = $"Couldn't find {searchFood} at { searchLocation }. Try another location";
                }
                ViewData["Location"] = searchLocation;
                ViewData["FoodSearch"] = searchFood;
            }


        }
    }
}
