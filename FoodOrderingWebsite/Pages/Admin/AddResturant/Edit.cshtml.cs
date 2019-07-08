using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;

namespace FoodOrderingWebsite.Pages.Admin.AddResturant
{
    public class EditModel : PageModel
    {
        private readonly FoodOrderingWebsite.Data.ApplicationDbContext _context;

        public EditModel(FoodOrderingWebsite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Resturant Resturant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Resturant = await _context.Resturants.FirstOrDefaultAsync(m => m.ID == id);

            if (Resturant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Resturant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResturantExists(Resturant.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ResturantExists(int id)
        {
            return _context.Resturants.Any(e => e.ID == id);
        }
    }
}
