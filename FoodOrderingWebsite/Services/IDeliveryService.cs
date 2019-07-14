using FoodOrderingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface IDeliveryService
    {
        Task<IEnumerable<DeliveryStatus>> GetUserDeliveryStatus(string userName);
    }
}
