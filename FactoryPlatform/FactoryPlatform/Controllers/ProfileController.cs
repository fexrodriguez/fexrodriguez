using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPlatform.Controllers
{
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class ProfileController : Controller
    {
        private readonly LUserProfile _lUserProfile;
        private readonly LUsers _lUsers;
        private readonly LUploadPictures _uploadPictures;
        private readonly LValidationLogin _lValidationLogin;
        public IWebHostEnvironment _environment;
        public LKQMXFPAPPContext _fpContext;
        public ProfileController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, IWebHostEnvironment hostEnvironment)
        {
            _lUserProfile = new LUserProfile(fpContext, appContext);
            _uploadPictures = new LUploadPictures();
            _lUsers = new LUsers(appContext);
            _environment = hostEnvironment;
            _fpContext = fpContext;
            _lValidationLogin = new LValidationLogin(appContext);
        }

        public IActionResult MyProfile()
        {
            var model = new UserProfile();

            model = _lUserProfile.GetUserPerfil(User);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPicture(IFormFile perfilPicture)
        {
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            string extension = Path.GetExtension(perfilPicture.FileName);
            if (extension == ".png" || extension == ".PNG" || extension == ".jpg" || extension == ".JPG" || extension == ".jpeg" || extension == ".JPEG")
            {
                var Imagen = await _uploadPictures.upProfilePicture(perfilPicture, _environment, "blank.png", idUsuario);

                var toUpdate = _fpContext.Users.SingleOrDefault(U => U.IdUsuario == idUsuario);

                if (toUpdate.Imagen == "blank.png")
                {
                    toUpdate.Imagen = Imagen;
                    _fpContext.Update(toUpdate);
                    _fpContext.SaveChanges();
                }
                return Ok(Imagen);
            }
            else
            {
                return Ok(null);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePass(string currentpassword, string newpassword)
        {
            var idUser = _lUsers.getIdUser(User).First().Id_Usuario;
            if (currentpassword != null && newpassword != null)
            {
                var result = _fpContext.Users.SingleOrDefault(U => U.IdUsuario == idUser);

                if (_lValidationLogin.CheckHash(currentpassword, result.PasswordHash, result.Salt))
                {
                    var hash = _lValidationLogin.Hash(newpassword);
                    result.PasswordHash = hash.Password;
                    result.Salt = hash.Salt;

                    _fpContext.Update(result);
                    _fpContext.SaveChanges();       

                    return Ok("Correcto");
                }
                else
                {
                    return Ok("passIncorrect");
                }
            }
            else
            {
                return Ok("Error");
            }
        }



    }
}
