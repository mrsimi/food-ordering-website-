using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;

namespace FoodOrderingWebsite.Pages.Admin.AddResturant
{
    public class IndexModel : PageModel
    {
        private readonly FoodOrderingWebsite.Data.ApplicationDbContext _context;

        public IndexModel(FoodOrderingWebsite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Resturant> Resturant { get;set; }

        public async Task OnGetAsync()
        {
            Resturant = await _context.Resturants.ToListAsync();
        }
    }
}
