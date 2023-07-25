using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FactoryPlatform.Controllers
{
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    //[ServiceFilter(typeof(AuthorizeActionFilter), Order = 2)]
    public class SectionsController : Controller
    {
        private StoresProceduresDbContext _SpContext;
        private LKQMXFPAPPContext _fpContext;
        private readonly LUsers _lUsers;
        public static SectionsViewModel _PageViewModel = new SectionsViewModel() { spFPAPP_Sys_SectionPages = new List<spFPAPP_Sys_SectionPages>() };
        public SectionsController(StoresProceduresDbContext SpContext, ApplicationDbContext AppContext, LKQMXFPAPPContext fpContext)
        {
            _SpContext = SpContext;
            _fpContext = fpContext;
            _lUsers = new LUsers(AppContext);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Pages(int idPage, string depName, string appName)
        {
            //validacion
            var model = new SectionsViewModel();
            model.spFPAPP_Sys_SectionPages = new List<spFPAPP_Sys_SectionPages>();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

            //Eliminar los registros Historicos de las Secciones
            var select = _fpContext.SoftwareConfigSectionsUserHistory.Where(H => H.UsuarioId == idUsuario).ToList();
            if (select.Any())
            {
                _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 1),
                }).ToList();
            }

            model.Department = depName;
            model.Aplication = appName;

            //traer las secciones y subsecciones de cada aplicacion
            model.spFPAPP_Sys_SectionPages = _SpContext.spFPAPP_Sys_SectionPages.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
            "@UserID=@UserID, @Operation=@Operation, @AppID=@AppID",
            new object[]
            {
              new SqlParameter("UserID", idUsuario),
              new SqlParameter("Operation", 2),
              new SqlParameter("AppID", idPage),
            }).ToList();

            if (model.spFPAPP_Sys_SectionPages.Any())
            {
                //Eliminar la seccion o subsection
                _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                 "@UserID=@UserID, @Operation=@Operation, @Departamento=@Departamento, @Aplicacion=@Aplicacion, @PageID=@PageID",
                 new object[]
                 {
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 3),
                  new SqlParameter("PageID", idPage),
                  new SqlParameter("Departamento", depName),
                  new SqlParameter("Aplicacion", appName),
                 }).ToList();

                _PageViewModel = model;
                return Redirect("/FactoryPlatform/Sections/Pages");
            }
            else
            {
                return Redirect("/FactoryPlatform");
            }
        }


        public async Task<IActionResult> Pages()
        {
            var modelo = new SectionsViewModel();
            modelo = _PageViewModel;
            _PageViewModel = new SectionsViewModel() { spFPAPP_Sys_SectionPages = new List<spFPAPP_Sys_SectionPages>() };

            if (modelo.spFPAPP_Sys_SectionPages.Count > 0)
            {
                ViewData["Department"] = modelo.Department;
                ViewData["Aplication"] = modelo.Aplication;
                return View(modelo);
            }
            else
            {
                var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

                var select = _fpContext.SoftwareConfigSectionsUserHistory.Where(H => H.UsuarioId == idUsuario).ToList();
                if (select.Count > 0)
                {
                    if (await ValidateSection(select.First().PageId, select.First().Departamento, select.First().Aplicacion))
                    {
                        modelo.spFPAPP_Sys_SectionPages = _PageViewModel.spFPAPP_Sys_SectionPages;
                        _PageViewModel = new SectionsViewModel() { spFPAPP_Sys_SectionPages = new List<spFPAPP_Sys_SectionPages>() };
                        return View(modelo);
                    }
                    else
                    {
                        return Redirect("/FactoryPlatform");
                    }
                }
                else
                {
                    return Redirect("/FactoryPlatform");
                }
            }

        }


        public async Task<bool> ValidateSection(int idPage, string depName, string appName)
        {
            bool error = true;
            var model = new SectionsViewModel();
            model.spFPAPP_Sys_SectionPages = new List<spFPAPP_Sys_SectionPages>();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

            var select = _fpContext.SoftwareConfigSectionsUserHistory.Where(H => H.UsuarioId == idUsuario).ToList();
            if (select.Any())
            {
                _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 1),
                }).ToList();
            }

            ViewData["Department"] = depName;
            ViewData["Aplication"] = appName;

            model.spFPAPP_Sys_SectionPages = _SpContext.spFPAPP_Sys_SectionPages.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
            "@UserID=@UserID, @Operation=@Operation, @AppID=@AppID", new object[]
            {
              new SqlParameter("UserID", idUsuario),
              new SqlParameter("Operation", 2),
              new SqlParameter("AppID", idPage),
            }).ToList();

            if (model.spFPAPP_Sys_SectionPages.Any())
            {
                _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation, @Departamento=@Departamento, @Aplicacion=@Aplicacion, @PageID=@PageID",
                new object[]
                {
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 3),
                  new SqlParameter("PageID", idPage),
                  new SqlParameter("Departamento", depName),
                  new SqlParameter("Aplicacion", appName),
                }).ToList();

                _PageViewModel = model;
            }

            return error;

        }


    }
}
