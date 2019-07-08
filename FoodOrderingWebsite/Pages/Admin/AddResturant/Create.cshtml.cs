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

namespace FoodOrderingWebsite.Pages.Admin.AddResturant
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

            long size = resturantImage.Length;
            var filePath = Path.GetTempFileName();
            if (resturantImage.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await resturantImage.CopyToAsync(stream);
                }
            }


            Resturant.ResturantImagesUriConcatenated= filePath;
            _context.Resturants.Add(Resturant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}