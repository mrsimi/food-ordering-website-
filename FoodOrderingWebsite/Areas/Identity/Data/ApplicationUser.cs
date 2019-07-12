using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Areas.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string  FullName { get; set; }
        public string  Address { get; set; }
        public string  Location { get; set; }
        public string  MobileNumber { get; set; }
    }
}
