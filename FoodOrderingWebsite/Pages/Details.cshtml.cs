using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodOrderingWebsite.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IDetailsService _detailsService; 
        public Food Food { get; set; }
        public Resturant Resturant { get; set; }


        public DetailsModel(IDetailsService detailsService)
        {
            _detailsService = detailsService;
        }
        public async Task<IActionResult> OnGetAsync(int? id, string sender)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (String.Equals(sender, "food"))
            {
                Food = await _detailsService.GetOneFood((int)id);
                if (Food == null)
                {
                    return NotFound();
                }
            }
            else if (String.Equals(sender, "resturant"))
            {
                Resturant = await _detailsService.GetOneResturant((int)id);
                if (Resturant == null)
                {
                    return NotFound();
                }
            }

            return Page();
            
        }
    }
}