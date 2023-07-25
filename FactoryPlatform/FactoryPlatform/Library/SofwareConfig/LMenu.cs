using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace FactoryPlatform.Library
{
    public class LMenu : ListObjects
    {
        private readonly LUsers _lUsers;
        public LMenu(StoresProceduresDbContext SpContext, ApplicationDbContext context)
        {
            _SpContext = SpContext;
            _lUsers = new LUsers(context);
        }

        public MenuViewModel GetMenu(IPrincipal user)
        {
            var model = new MenuViewModel();
  
            var IdUsuario = _lUsers.getIdUser(user);

            var menuDepartaments = _SpContext.spFPAPP_Sys_menus.FromSqlRaw("EXEC spFPAPP_Sys_menus @UserID=@UserID", new object[]
            {
                 new SqlParameter("UserID", IdUsuario.First().Id_Usuario)
            }).AsNoTracking().ToList();


            if (menuDepartaments.Count > 0)
            {
                model.spFPAPP_Sys_menus = menuDepartaments;

                 var  menuApp = _SpContext.spFPAPP_Sys_apps.FromSqlRaw("EXEC spFPAPP_Sys_apps @UserID=@UserID", new object[]
                {
                    new SqlParameter("UserID", IdUsuario.First().Id_Usuario)
                }).AsNoTracking().ToList();

                if (menuApp.Count > 0)
                {
                    model.spFPAPP_Sys_apps = menuApp;
                }
            }

            return model;
        }


    }
}
