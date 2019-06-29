using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Data;

namespace FoodOrderingWebsite.Services
{
    public class UserOperationDbService : IUserOperationDbService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserOperationDbService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ApplicationDbContext GetDbContext()
        {
            return _dbContext;
        }
    }
}
