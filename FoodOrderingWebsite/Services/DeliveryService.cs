using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebsite.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IUserOperationDbService _db;
        public DeliveryService(IUserOperationDbService db)
        {
            _db = db;
        }
        public async Task<IEnumerable<DeliveryStatus>> GetUserDeliveryStatus(string userName)
        {
            return await _db.GetDbContext().DeliveryStatuses.Where(m => m.UserName == userName).ToListAsync();
        }
    }
}
