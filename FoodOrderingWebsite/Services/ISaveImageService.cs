using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public interface ISaveImageService
    {
        Task<string> SaveImageToFileAsync(IFormFile image);
    }
}
