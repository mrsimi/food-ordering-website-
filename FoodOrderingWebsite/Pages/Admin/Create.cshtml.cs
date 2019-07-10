using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using FoodOrderingWebsite.Services;

namespace FoodOrderingWebsite.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly FoodOrderingWebsite.Data.ApplicationDbContext _context;
        private readonly ISaveImageService _imgService;


        public CreateModel(FoodOrderingWebsite.Data.ApplicationDbContext context, ISaveImageService imgService)
        {
            _context = context;
            _imgService = imgService;
        }

        public IActionResult OnGet()
        {
        ViewData["ResturantID"] = new SelectList(_context.Resturants, "ID", "ResturantName");
            return Page();
        }

        [BindProperty]
        public Food Food { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile foodImage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            if (foodImage.Length > 0)
            {
                Food.FoodImagesUriConcatenated= await _imgService.SaveImageToFileAsync(foodImage);
            }
            else
            {
                Food.FoodImagesUriConcatenated = "";
            }

            
           
            _context.Foods.Add(Food);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}