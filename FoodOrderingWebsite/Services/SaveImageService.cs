using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace FoodOrderingWebsite.Services
{
    public class SaveImageService : ISaveImageService
    {
        private readonly IHostingEnvironment _env;
        public SaveImageService(IHostingEnvironment env)
        {
            _env = env;
        }
        public async Task<string> SaveImageToFileAsync(IFormFile image)
        {
            string uniqueFileName = GetUniqueFileName(image);
            var uploads = Path.Combine(_env.WebRootPath, "uploads");
            var filePath = Path.Combine(uploads, uniqueFileName);
            await image.CopyToAsync(new FileStream(filePath, FileMode.Create));

            return uniqueFileName;
            //var path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\uploads", uniqueFileName);
            //using (var bits = new FileStream(path, FileMode.Create))
            //{
            //    await image.CopyToAsync(bits);
            //}

            //return uniqueFileName;
        }



        private string GetUniqueFileName(IFormFile image)
        {
            string name = Path.GetFileName(image.FileName);
            return Path.GetFileNameWithoutExtension(name)
                + "_" + Guid.NewGuid().ToString().Substring(0, 4) + Path.GetExtension(name);
        }
    }
}
