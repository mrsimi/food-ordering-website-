using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodOrderingWebsite.Data;
using FoodOrderingWebsite.Models;
using FoodOrderingWebsite.Services;

namespace FoodOrderingWebsite.Pages
{
    public class TrackOrdersModel : PageModel
    {
        private readonly IDeliveryService _deliveryService;

        public TrackOrdersModel(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public IEnumerable<DeliveryStatus> DeliveryStatus { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                string userEmail = User.FindFirst("Email").Value;
                DeliveryStatus = await _deliveryService.GetUserDeliveryStatus(userEmail);
                return Page();
            }
            catch (NullReferenceException)
            {
                return Redirect("~/Identity/Account/Login");
            }
            
        }
    }
}
