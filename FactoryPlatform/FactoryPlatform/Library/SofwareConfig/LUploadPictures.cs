using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace FactoryPlatform.Library
{
    public class LUploadPictures
    {

        public async Task<string> upProfilePicture(IFormFile Picture, IWebHostEnvironment environment, string image, int IdUsuario)
        {
            if (Picture != null)
            {
                string wwwRootPath = environment.WebRootPath;
                string extension = Path.GetExtension(Picture.FileName);
                image = IdUsuario + ".jpg";
                string path = Path.Combine(wwwRootPath + "/Images/ProfilePictures", image);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await Picture.CopyToAsync(fileStream);
                }
                return image;
            }
            else
            {
                return image;
            }

        }

    }
}
