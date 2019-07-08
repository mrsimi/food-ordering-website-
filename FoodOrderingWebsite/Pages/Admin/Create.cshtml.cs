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

namespace FoodOrderingWebsite.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly FoodOrderingWebsite.Data.ApplicationDbContext _context;

        public CreateModel(FoodOrderingWebsite.Data.ApplicationDbContext context)
        {
            _context = context;
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

            long size = foodImage.Length;
            var filePath = Path.GetTempFileName();
            if (foodImage.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await foodImage.CopyToAsync(stream);
                }
            }

            
            Food.FoodImagesUriConcatenated = filePath;
            _context.Foods.Add(Food);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}