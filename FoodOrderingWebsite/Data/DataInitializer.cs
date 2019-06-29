using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Data
{
    public static class DataInitializer
    {
        public static void PopulateDbSampleData(ApplicationDbContext _dbContext)
        {
            if (_dbContext.Resturants.Any())
            {
                return;
            }

            var resturants = new Resturant[]
            {
                new Resturant {ID = 1, ResturantName = "Eataway", Address = "11, Layout 14 Industrial Estate, Express Way",
                    Location = "Akure", OpeningHours = "8:00am - 8:00pm", ResturantImagesUriConcatenated = "http://image1 + http://image2"  },

                  new Resturant {ID = 2, ResturantName = "Delic", Address = "Riverside North gate",
                    Location = "Akure", OpeningHours = "8:00am - 8:00pm", ResturantImagesUriConcatenated = "http://image5riverside + http://image5riverside"  },

                new Resturant {ID = 3, ResturantName = "Foodie", Address = "Layout 13, Bank Road",
                    Location = "Lagos", OpeningHours = "10:00am - 8:00pm", ResturantImagesUriConcatenated = "http://image1foodie + http://image2foodie" },
            };
            _dbContext.Resturants.AddRange(resturants);

            var foods = new Food[]
            {
                new Food {ID = 1, FoodName = "Burger King size", Description = "Made from the flour from our organically grown farm",
                    Price = 9.00m, ResturantID = 1, FoodImagesUriConcatenated = "http://imageBurgerKingsize1 + http://imageBurgerKingsize2"},
                new Food {ID = 2, FoodName = "Black Coffee", Description = "Black Coffee made from South African ",
                    Price = 9.00m, ResturantID = 2, FoodImagesUriConcatenated = "http://imageBlackCoffee1 + http://imageBlackCoffee2"},
                new Food {ID = 3, FoodName = "Pizza", Description = "The sauce comes from the legendary chef",
                    Price = 9.00m, ResturantID = 1, FoodImagesUriConcatenated = "http://imagePizza1 + http://imagePizza2"},
            };

            _dbContext.Foods.AddRange(foods);
        }
    }
}
