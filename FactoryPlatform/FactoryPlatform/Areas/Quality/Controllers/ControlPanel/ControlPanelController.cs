using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using FactoryPlatform.Library.Quality;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Filter;
using System.Threading.Tasks;
using FactoryPlatform.Models;
using Microsoft.EntityFrameworkCore;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.DocumentList;
using Microsoft.Data.SqlClient;
using System;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using System.Collections.Generic;
using System.IO;
using System.Net;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.UpdModelToSerie;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Packaging;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelSequences;

namespace FactoryPlatform.Areas.Quality.Controllers
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    [ServiceFilter(typeof(AuthorizeMethodFilter), Order = 2)]
    public class ControlPanelController : Controller
    {

        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private readonly LUsers _lUsers;
        private readonly LCorrectiveAction_CP _lCorrectiveActiosCP;
        private readonly LModels _lModels;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;
        private readonly LModelFeature_CP _lModelFeature;
        private readonly LStopModels_CP _lStopModels;
        private readonly LPackaging_CP _lPackaging;
        private readonly LModelSequences _lModelSequences;

        public static CorrectiveAction_CP_ModelView _CorrectiveActionsCP = new CorrectiveAction_CP_ModelView();
        public static DocumentList_CP_ModelView _DocumentListCP = new DocumentList_CP_ModelView();
        public static CP_ModelsModelView _ModelsCP = new CP_ModelsModelView();
        public static CP_ModelFeaturesViewModel _ModelsFeaturesCP = new CP_ModelFeaturesViewModel();
        public static CP_UpdModelToSerieModelView _UpdModelToSerieModeCP = new CP_UpdModelToSerieModelView();
        public static CP_StopModelsView _StopModelCP = new CP_StopModelsView();
        public static CP_PackagindModelView _PackagindCP = new CP_PackagindModelView();
        public static CP_ModelSequencesViewModel _ModelSequencesCP = new CP_ModelSequencesViewModel();
        public static int valida_planta = 0;
        public static string valida_modelo = string.Empty;
        public static int valida_registro = 0;
        public ControlPanelController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lUsers = new LUsers(appContext);
            _lCorrectiveActiosCP = new LCorrectiveAction_CP(spContext);
            _lModels = new LModels(spContext);
            _lModelFeature = new LModelFeature_CP(spContext);
            _lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);
            _lStopModels = new LStopModels_CP(spContext);
            _lPackaging = new LPackaging_CP(spContext);
            _lModelSequences = new LModelSequences(spContext);
        }

        //===================================Conrrective Action Control Panel==================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CorrectiveActions(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CorrectiveAction_CP_ModelView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _CorrectiveActionsCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/CorrectiveActions");
        }

        public IActionResult CorrectiveActions()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CorrectiveAction_CP_ModelView();
            model = _CorrectiveActionsCP;
            _CorrectiveActionsCP = new CorrectiveAction_CP_ModelView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;
                var query = _lCorrectiveActiosCP.CorrectiveActionInf(UserInfo.Id_Usuario, UserInfo.PlantaId);
                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;

                return View(query);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
                "@UserID=@UserID, @Operation=@Operation",
                new object[]
                {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
                }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        model = _lCorrectiveActiosCP.CorrectiveActionInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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
        //===================================================================================================================================


        //===================================-Document List-=================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DocumentList(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new DocumentList_CP_ModelView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _DocumentListCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/DocumentList");
        }

        public IActionResult DocumentList()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new DocumentList_CP_ModelView();
            model = _DocumentListCP;
            _DocumentListCP = new DocumentList_CP_ModelView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                //var query = _lCorrectiveActiosCP.CorrectiveActionInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                return View(model);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        //model = _lCorrectiveActiosCP.CorrectiveActionInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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

        //================================================================================================================================

        //===================================-Models -=====================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Models(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CP_ModelsModelView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _ModelsCP  = model;

            return Redirect("/FactoryPlatform/ControlPanel/Models");
        }

        public IActionResult Models()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_ModelsModelView();
            model = _ModelsCP;
            _ModelsCP = new CP_ModelsModelView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;
                query.Tipo = model.Tipo;

                return View(query);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        model = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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

        //==================================================================================================================================

        //===============================================-Model Feature -=================================================================================
        //Maping Rute 
        public List<string> MapRute(int PlantaId, string Modelo, int IdRegistro)
        {
            var error = "";
            List<string> files = new List<string>();
            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;
            var user = "";
            var passworda = "";

            var query = _spContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
               new object[]
               {
                    new SqlParameter("UserID", idUsuario)
               }).AsNoTracking().ToList();

            if (query.Count > 0)
            {
                var model = query.First();

                user = model.Usuario;
                passworda = model.Password;
            }

            int validated_planta_host = valida_planta;
            string validated_modelo_host = valida_modelo;
            int validated_registro_host = valida_registro;

            if (PlantaId.Equals(validated_planta_host) && Modelo.Equals(validated_modelo_host) && IdRegistro.Equals(validated_registro_host))
            {
                string url = $"ftp://10.208.122.234/photocenter/Planta{validated_planta_host}/model-features/{validated_modelo_host}/{validated_registro_host}/large";

                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(url);

                try
                {
                    request.Credentials = new NetworkCredential(user, passworda);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);

                    var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (ftpFiles.Count > 0)
                    {
                        files = ftpFiles;
                    }

                    response.Close();
                    responseStream.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }

                return files;
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Features(int SeccionId, int Tipo, string modelo, int estacion,
        string Title, string Description)
        {
            var IdUser = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser.Id_Usuario, Tipo);

            var model = new CP_ModelFeaturesViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo,
                Modelo = modelo,
                Estacion = estacion,
                Title = Title,
                Description = Description,
                PlantaId = IdUser.PlantaId
            };

            _ModelsFeaturesCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/Features");
        }

        public IActionResult Features()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_ModelFeaturesViewModel();
            model = _ModelsFeaturesCP;
            _ModelsFeaturesCP = new CP_ModelFeaturesViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();

            if ((model.Modelo != null && model.Modelo != "") && (model.Estacion > 0))
            {
                model.CP_Q_ModelFeature = _lModelFeature.SearchModel(model.Modelo, model.Estacion, UserInfo.Id_Usuario, UserInfo.PlantaId);

                if (model.CP_Q_ModelFeature.Any())
                {
                    var filesInf = new List<FilesModelFeactures>();
                    foreach (var item in model.CP_Q_ModelFeature)
                    {
                        valida_planta = item.PlantaID;
                        valida_modelo = item.Modelo;
                        valida_registro = item.ID_Registro;
                        var files = MapRute(item.PlantaID, item.Modelo, item.ID_Registro);
                        foreach (var name in files)
                        {
                            filesInf.Add(new FilesModelFeactures
                            {
                                RegistroId = item.ID_Registro,
                                FileName = name
                            });
                        }
                    }

                    model.FilesModelFeactures = filesInf;
                }

            }


            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lModelFeature.ModelFeaturesInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;
                query.Tipo = model.Tipo;

                query.PlantaId = model.PlantaId;

                query.Modelo = model.Modelo;
                query.Estacion = model.Estacion;

                query.CP_Q_ModelFeature = model.CP_Q_ModelFeature;
                query.FilesModelFeactures = model.FilesModelFeactures;

                return View(query);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        model = _lModelFeature.ModelFeaturesInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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
        //===================================================================================================================================

        //===================================- Update Model To Serie -=====================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdModelToSerie(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CP_UpdModelToSerieModelView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _UpdModelToSerieModeCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/UpdModelToSerie");
        }

        public IActionResult UpdModelToSerie()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_UpdModelToSerieModelView();
            model = _UpdModelToSerieModeCP;
            _UpdModelToSerieModeCP = new CP_UpdModelToSerieModelView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                //var query = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                //query.TituloSeccion = model.TituloSeccion;
                //query.IdSeccion = model.IdSeccion;
                //query.Tipo = model.Tipo;

                return View(model);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        //model = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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

        //==================================================================================================================================

        //===================================- Stop Models -=====================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StopModels(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CP_StopModelsView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _StopModelCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/StopModels");
        }

        public IActionResult StopModels()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_StopModelsView();
            model = _StopModelCP;
            _StopModelCP = new CP_StopModelsView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lStopModels.StopedsModels(UserInfo.Id_Usuario, UserInfo.PlantaId);

                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;
                query.Tipo = model.Tipo;

                return View(query);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        model = _lStopModels.StopedsModels(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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

        //==================================================================================================================================     

        //===================================- Models Sequences -============================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModelSequences(int SeccionId, int Tipo, string modelo, int estacion,
           int ModalNumber, string Title, string Description)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CP_ModelSequencesViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo

            };

            _ModelSequencesCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/ModelSequences");
        }

        public IActionResult ModelSequences()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_ModelSequencesViewModel();
            model = _ModelSequencesCP;
            _ModelSequencesCP = new CP_ModelSequencesViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();

            var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
           "@UserID=@UserID, @Operation=@Operation",
           new object[]
           {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
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
                    model.Tipo = select.First().Tipo;

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
        //==================================================================================================================================


        //===================================- Packing -=====================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Packaging(int SeccionId, int Tipo)
        {
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            var model = new CP_PackagindModelView()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _PackagindCP = model;

            return Redirect("/FactoryPlatform/ControlPanel/Packaging");
        }

        public IActionResult Packaging()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CP_PackagindModelView();
            model = _PackagindCP;
            _PackagindCP = new CP_PackagindModelView();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lPackaging.GetPacking(UserInfo.Id_Usuario, UserInfo.PlantaId);

                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;
                query.Tipo = model.Tipo;

                return View(query);
            }
            else
            {
                var select = _spContext.PaginaInf_Global.FromSqlRaw("EXEC spFPAPP_Sys_SectionPages " +
               "@UserID=@UserID, @Operation=@Operation",
               new object[]
               {
                  new SqlParameter("UserID", UserInfo.Id_Usuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();

                if (select.Count > 0)
                {
                    string[] Separado = select.First().NewDireccion.Split('/');
                    string Final = Separado[Separado.Length - 1];

                    if (action.ToString() == Final)
                    {
                        model = _lPackaging.GetPacking(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.IdSeccion = select.First().IdSection;
                        model.Tipo = select.First().Tipo;

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

        //==================================================================================================================================


        //========================================- -=====================================================================================

        //==================================================================================================================================


    }
}
