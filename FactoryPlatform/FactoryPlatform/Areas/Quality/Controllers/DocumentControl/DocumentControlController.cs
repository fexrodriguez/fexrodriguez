using Azure;
using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FactoryPlatform.Areas.Quality.Controllers
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    [ServiceFilter(typeof(AuthorizeMethodFilter), Order = 2)]
    public class DocumentControlController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private LDocumentControl _lDocControl;
        private readonly LUsers _lUsers;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;
        public static DocumentListViewModel _DocumentList = new DocumentListViewModel();

        public DocumentControlController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lDocControl = new LDocumentControl(spContext, fpContext);
            _lUsers = new LUsers(appContext);
            _lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);
        }


        //======================================Document list==========================================================================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DocumentList(int SeccionId, int Planta, int Departament, int Stations, int Status, 
        string Key, string Description, int IdSeccion, int Tipo)
        {
            var UserInf = _lUsers.getIdUser(User).First();
            var model = new DocumentListViewModel();
            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInf.Id_Usuario, Tipo);

            model = new DocumentListViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
            };

            model.IdSeccion = SeccionId;
            model.Planta = Planta;
            model.Departamento = Departament;
            model.Estacion = Stations;
            model.Clave = Key != null ? Key : "-";
            model.Description = Description != null ? Description : "-";
            model.Status = Status;
            model.Tipo = Tipo;

            _DocumentList = model;

            return Redirect("/FactoryPlatform/DocumentControl/DocumentList");
        }

        public IActionResult DocumentList()
        {
            _spContext.Database.SetCommandTimeout(1500);
            var action = (HttpContext.Request.RouteValues.Values).Last();
            var model = new DocumentListViewModel();
            model = _DocumentList;
            _DocumentList = new DocumentListViewModel();

            var docList = new List<StoresDocumentList>();
            var siglist = new List<DocumentList_Signature>();

            var UserInf = _lUsers.getIdUser(User).First();
            model.Id_Usuario = UserInf.Id_Usuario;

            model.Clave = model.Clave != null ? model.Clave : "-";
            model.Description = model.Description != null ? model.Description : "-";
            if (model.Clave != "-" || model.Description != "-" || ((model.Planta > 0 && model.Departamento > 0) || model.Status > 0))
            {

                docList = _lDocControl.DocumentList(model.Planta, model.Departamento, model.Estacion, model.Status, model.Clave, model.Description, UserInf.Id_Usuario);

                if (docList.Any())
                {
                    model.StoresDocumentList = docList;

                    var searchSign = docList.Select(S => S.ID_Documento).ToList();
                    var jsonListaDatos = JsonConvert.SerializeObject(searchSign);

                    siglist = _lDocControl.DocListSignatures(UserInf.Id_Usuario, jsonListaDatos);

                    if (siglist.Any())
                    {
                        model.DocumentList_Signature = siglist;
                    }
                }
            }

            model.UsersPrivileges = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 4 && Q.UsuarioId == UserInf.Id_Usuario).AsNoTracking().ToList();
            model.PrivilageNewReview = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 1 && Q.UsuarioId == UserInf.Id_Usuario).AsNoTracking().ToList();
            model.UpdateKey = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 11 && Q.UsuarioId == UserInf.Id_Usuario).AsNoTracking().ToList();
            model.PrivilegeObsolete = _fpContext.QualityDocsUsersPrivileges.Where(Q => Q.PrivilegioId == 12 && Q.UsuarioId == UserInf.Id_Usuario).AsNoTracking().ToList();
            model.Factories = _lDocControl.ComboData(UserInf.Id_Usuario, 1, UserInf.PlantaId, 0).Factories;
            model.ProductionStations = _lDocControl.ComboData(UserInf.Id_Usuario, 4, UserInf.PlantaId, 0).ProductionStations;
            model.DocumentsKeys = _lDocControl.ComboData(UserInf.Id_Usuario, 5, UserInf.PlantaId, 0).DocumentsKeys;
            model.OriginChange = _lDocControl.ComboData(UserInf.Id_Usuario, 7, UserInf.PlantaId, 0).OriginChange;
            model.UsersReponsables = _lDocControl.ComboData(UserInf.Id_Usuario, 8, UserInf.PlantaId, 0).UsersReponsables;

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;
                return View(model);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                    new SqlParameter("UserID", UserInf.Id_Usuario),
                    new SqlParameter("Operation", 6)
                }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;

                        return View(model);
                    }
                    else
                    {
                        return Redirect("/FactoryPlatform");
                    }
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }

        //================================================================================================================================================================================




    }
}
