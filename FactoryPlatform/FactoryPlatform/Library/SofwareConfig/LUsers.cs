using FactoryPlatform.Data;
using FactoryPlatform.Helper;
using FactoryPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace FactoryPlatform.Library
{
    public class LUsers : ListObjects
    {
        public LUsers(ApplicationDbContext context)
        {
            _appContext = context;
        }

        public List<Models.Users> getIdUser(IPrincipal user)
        {
            List<Models.Users> listUser = new List<Models.Users>();
            var correo = user.Identity.Name;

            if (correo.Contains("@"))
            {
                var userInf = _appContext.Users.Where(u => u.Correo.Equals(correo) && u.Status.Equals(true)).Select(u => new Models.Users
                {
                    Id_Usuario = u.Id_Usuario,
                    Usuario = u.Usuario,
                    PlantaId = u.PlantaId
                }).AsNoTracking().ToList();

                if (userInf.Count > 0)
                {
                    listUser = userInf;
                }
            }
            else
            {
                var userInf = _appContext.Users.Where(u => u.Usuario.Equals(CookieHelper.GetUsuario(user)) && u.Status.Equals(true) ).Select(u => new Models.Users
                {
                    Id_Usuario = u.Id_Usuario,
                    Usuario = u.Usuario,
                    PlantaId = u.PlantaId
                }).AsNoTracking().ToList();

                if(userInf.Count > 0)
                {
                    listUser = userInf;
                }

            }

            return listUser;
        }


    }
}
