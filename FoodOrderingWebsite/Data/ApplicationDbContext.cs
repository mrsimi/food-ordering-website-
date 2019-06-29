using System;
using System.Collections.Generic;
using System.Text;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
    }
}
