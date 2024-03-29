﻿using System;
using System.Collections.Generic;
using System.Text;
using FoodOrderingWebsite.Areas.Identity;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
    }
}
