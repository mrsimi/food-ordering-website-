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

namespace FoodOrderingWebsite.Pages.Admin.AddResturant
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
            return Page();
        }

        [BindProperty]
        public Resturant Resturant { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile resturantImage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (resturantImage.Length > 0)
            {
                Resturant.ResturantImagesUriConcatenated = await _imgService.SaveImageToFileAsync(resturantImage);
            }
            else
            {
                Resturant.ResturantImagesUriConcatenated = "";
            }

            _context.Resturants.Add(Resturant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}