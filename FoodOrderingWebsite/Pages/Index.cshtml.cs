using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Pages
{
    [ValidateAntiForgeryToken]
    public class IndexModel : PageModel
    {
        private readonly ISearchService _searchService;
        private readonly ICartService _cartService;

        public IndexModel(ISearchService searchService, ICartService cartService)
        {
            _searchService = searchService;
            _cartService = cartService;
        }

        public IEnumerable<Resturant> ResturantList { get; set; }
        public IEnumerable<Food> FoodList { get; set; }

        [BindProperty]
        public int SelectedLocation { get; set; }
        public SelectList LocationOptions { get; set; }


        //hardcoded location for testing
        string[] resturantsLocation = new string[] { "Akure", "Lagos" };

        public async Task OnGetAsync()
        {

            Random random = new Random();
            string randomLocation = resturantsLocation[random.Next(resturantsLocation.Count())];

            var resturants = await _searchService.GetResturantsByLocation(randomLocation);
            ResturantList = resturants;

            LocationOptions = new SelectList(resturantsLocation, randomLocation);

            ViewData["FoodSearch"] = "";
            ViewData["Location"] = randomLocation;
            ViewData["SearchError"] = "";

        }

        public async Task OnPostAsync()
        {
            string searchFood, searchLocation = "";

            searchLocation = Request.Form["searchLocationParams"];
            searchFood = Request.Form["searchFoodParams"];


            LocationOptions = new SelectList(resturantsLocation, searchLocation);

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

        public async Task OnPostOrders(int Id, string foodName, decimal foodPrice, string resturantName, string foodSearch, string locationSearch)
        {
            var foodInfo = new Cart()
            {
                FoodName = foodName,
                FoodPrice = foodPrice,
                ResturantName = resturantName,
                UserName = "simi",
                ResturantId = Id
            };

            await _cartService.AddToCart(foodInfo);
        }
    }
}
