using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Areas.Identity
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, 
            IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            var claims = new List<Claim>
            {
                new Claim("FullName", user.FullName),
                new Claim("Location", user.Location),
                new Claim("Address", user.Address),
                new Claim("MobileNumber", user.MobileNumber),
                new Claim("Email", user.Email)
            };
            identity.AddClaims(claims);
            return identity;
        }
    }
}
