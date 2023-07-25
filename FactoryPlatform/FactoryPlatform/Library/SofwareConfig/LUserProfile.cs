using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace FactoryPlatform.Library
{
    public class LUserProfile : ListObjects
    {
        private readonly LUsers _lUsers;
        public LUserProfile(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _lUsers = new LUsers(appContext);
        }

        public UserProfile GetUserPerfil(IPrincipal claimsUsers)
        {
            var Result = new UserProfile();

            var IdUsuario = _lUsers.getIdUser(claimsUsers).First();

            var userData = (from user in _fpContext.Users
                            //join HR in _fpContext.HumanResourcesEmployees on user.Usuario equals HR.NoEmpleado
                            join UJ in _fpContext.UsersJobs on user.PuestoId equals UJ.IdPuestoTrabajo
                            select new
                            {
                                user.IdUsuario,
                                user.Usuario,
                                user.Nombres,
                                user.ApellidoPaterno,
                                user.ApellidoMaterno,
                                user.NoEmpleado,
                                user.Correo,
                                user.Imagen,
                                user.Status,
                                UJ.Descripcion
                            }).Where(U => U.IdUsuario == IdUsuario.Id_Usuario).AsNoTracking().ToList();

            if (userData.Count > 0)
            {
                var UserInf = userData.First();
                Result = new UserProfile()
                {
                    IdUsuario = UserInf.IdUsuario,
                    Usuario = UserInf.Usuario,
                    Nombres = UserInf.Nombres,
                    ApellidoPaterno = UserInf.ApellidoPaterno,
                    ApellidoMaterno = UserInf.ApellidoMaterno,
                    NoEmpleado = UserInf.NoEmpleado,
                    Correo = UserInf.Correo,
                    Image = UserInf.Imagen,
                    Puesto = UserInf.Descripcion
                };

            }

            return Result;

        }


    }
}
