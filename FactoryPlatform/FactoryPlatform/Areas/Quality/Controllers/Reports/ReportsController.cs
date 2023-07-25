using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Library.Quality;
using FactoryPlatform.Areas.Quality.Models;
using System.Linq;
using FactoryPlatform.Filter;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart;
using FactoryPlatform.Library.Quality.Reports.CorrectiveActions;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList;
using FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureList;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelsSequencesList;
using FactoryPlatform.Library.Quality.Reports.Models.ModelSecuencesList;
using FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureRecord;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelChanges;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureMatrix;
using FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureMatrix;

namespace FactoryPlatform.Areas.Quality.Controllers
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    [ServiceFilter(typeof(AuthorizeMethodFilter), Order = 2)]
    public class ReportsController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private readonly LUsers _lUsers;
        private readonly LCorrectiveActiosList _lCorrectiveActiosList;
        private readonly LCorrectiveActionsChart _lCorrectiveActionsChart;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;
        private readonly LModelFeature_CP _lModelFeature;
        private readonly LModelFeatureList _lModelFeatureList;
        private readonly LModelSecuences _lModelSecuencesList;
		private readonly LModelFeaturesRecord _lModelFeaturesRecord;
		private readonly LModelFeatureMatrix _lModelFeatureMatrix;

		public static CorrectiveActionListViewModel _CorrectiveActionsList = new CorrectiveActionListViewModel();
        public static CorrectiveActionChartViewModel _CorrectiveActionsChart = new CorrectiveActionChartViewModel();
        public static CP_ModelFeaturesViewModel _ModelsFeaturesCP = new CP_ModelFeaturesViewModel();
        public static R_ModelFeatureListViewModel _ModelsFeaturesListCP = new R_ModelFeatureListViewModel();
        public static R_ModelsSequencesListViewModel _ModelSecuencesListCP = new R_ModelsSequencesListViewModel();
		public static R_ModelFeatureRecordListViewModel _lModelFeaturesRecordReport = new R_ModelFeatureRecordListViewModel();
		public static R_ModelFeatureMatrixViewModel _lModelFeatureMatrixLibrary = new R_ModelFeatureMatrixViewModel();

        public static int valida_planta = 0;
        public static string valida_modelo = string.Empty;
        public static int valida_registro = 0;
        public ReportsController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lUsers = new LUsers(appContext);
            _lModelFeature = new LModelFeature_CP(spContext);
            _lModelFeatureList = new LModelFeatureList(spContext);
            _lModelSecuencesList = new LModelSecuences(spContext);
            _lCorrectiveActiosList = new LCorrectiveActiosList(spContext);
            _lCorrectiveActionsChart = new LCorrectiveActionsChart(spContext);
			_lModelFeaturesRecord = new LModelFeaturesRecord(spContext);
			_lModelFeatureMatrix = new LModelFeatureMatrix(spContext);
			_lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);
        }


        //===============================================-Corrective Action List-==================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> CorrectiveActionsList(int SeccionId, int Tipo)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

            var model = new CorrectiveActionListViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _CorrectiveActionsList = model;

            return Redirect("/FactoryPlatform/Reports/CorrectiveActionsList");
        }

        public IActionResult CorrectiveActionsList()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CorrectiveActionListViewModel();
            model = _CorrectiveActionsList;
            _CorrectiveActionsList = new CorrectiveActionListViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                ViewData["Titulo"] = model.TituloSeccion;
                var query = _lCorrectiveActiosList.CorrectiveActionCombos(UserInfo.Id_Usuario, UserInfo.PlantaId);
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
                        model = _lCorrectiveActiosList.CorrectiveActionCombos(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.TituloSeccion = select.First().PageTitle;
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
        //=================================================================================================

        //===============================================-Corrective Action Chart-==================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CorrectiveActionsChart(int SeccionId, int Tipo)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

            var model = new CorrectiveActionChartViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo
            };

            _CorrectiveActionsChart = model;

            return Redirect("/FactoryPlatform/Reports/CorrectiveActionsChart");
        }

        public IActionResult CorrectiveActionsChart()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new CorrectiveActionChartViewModel();
            model = _CorrectiveActionsChart;
            _CorrectiveActionsChart = new CorrectiveActionChartViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();

            if (model.IdSeccion > 0)
            {
                
                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lCorrectiveActionsChart.CorrectiveActionCombos(UserInfo.Id_Usuario, UserInfo.PlantaId);

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
                        model = _lCorrectiveActionsChart.CorrectiveActionCombos(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.TituloSeccion = select.First().PageTitle;
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
        //=================================================================================================   

        //===============================================-Model Feauture-==================================================
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
                request.Method = WebRequestMethods.Ftp.DownloadFile;
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

            return Redirect("/FactoryPlatform/Reports/Features");
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

        //==========================================Model FeaturesList=========================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FeaturesList(int SeccionId, int Tipo, int EstacionID, int EmployeeID)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

            var model = new R_ModelFeatureListViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo,
                EstacionID = EstacionID,
                EmployeeID = EmployeeID
            };

            _ModelsFeaturesListCP= model;

            return Redirect("/FactoryPlatform/Reports/FeaturesList");
        }

        public IActionResult FeaturesList()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new R_ModelFeatureListViewModel();
            model = _ModelsFeaturesListCP;
            _ModelsFeaturesListCP = new R_ModelFeatureListViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();


            if((model.EmployeeID > 0) && (model.EstacionID > 0))
            {
                model.R_ModelFeatureList =_lModelFeatureList.GetReport(model.EmployeeID.Value, UserInfo.PlantaId, model.EstacionID.Value).R_ModelFeatureList;
            }

            if (model.IdSeccion > 0)
            {

                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lModelFeatureList.GetModelFeatureView(UserInfo.Id_Usuario, UserInfo.PlantaId);

                query.TituloSeccion = model.TituloSeccion;
                query.IdSeccion = model.IdSeccion;

                query.EstacionID = model.EstacionID;
                query.EmployeeID = model.EmployeeID;

                query.R_ModelFeatureList = model.R_ModelFeatureList;

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
                        model = _lModelFeatureList.GetModelFeatureView(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.TituloSeccion = select.First().PageTitle;
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


        //==========================================Model Sequences List=========================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SequencesList(int SeccionId, int Tipo)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

            var model = new R_ModelsSequencesListViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo,
            };

            _ModelSecuencesListCP = model;

            return Redirect("/FactoryPlatform/Reports/SequencesList");
        }

        public IActionResult SequencesList()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new R_ModelsSequencesListViewModel();
            model = _ModelSecuencesListCP;
            _ModelSecuencesListCP = new R_ModelsSequencesListViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();


            if (model.IdSeccion > 0)
            {

                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lModelSecuencesList.GetReport(UserInfo.Id_Usuario, UserInfo.PlantaId);

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
                        model = _lModelSecuencesList.GetReport(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.TituloSeccion = select.First().PageTitle;
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
        
        //==========================================Model Feature Record =========================================================================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FeaturesRecords(int SeccionId, int Tipo)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

            var model = new R_ModelFeatureRecordListViewModel()
            {
                IdSeccion = SeccionId,
                TituloSeccion = historyPagesInf.PageTitle,
                Tipo = Tipo,
            };

			_lModelFeaturesRecordReport = model;

            return Redirect("/FactoryPlatform/Reports/FeaturesRecords");
        }

        public IActionResult FeaturesRecords()
        {
            var action = (HttpContext.Request.RouteValues.Values).Last();

            var model = new R_ModelFeatureRecordListViewModel();
            model = _lModelFeaturesRecordReport;
			_lModelFeaturesRecordReport = new R_ModelFeatureRecordListViewModel();

            var UserInfo = _lUsers.getIdUser(User).First();


            if (model.IdSeccion > 0)
            {

                ViewData["Titulo"] = model.TituloSeccion;

                var query = _lModelFeaturesRecord.GetModelFeature(UserInfo.Id_Usuario, UserInfo.PlantaId);

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
                        model = _lModelFeaturesRecord.GetModelFeature(UserInfo.Id_Usuario, UserInfo.PlantaId);

                        ViewData["Titulo"] = select.First().PageTitle;
                        model.TituloSeccion = select.First().PageTitle;
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

		//==========================================Model Change =========================================================================================
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ModelChanges(int SeccionId, int Tipo)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

			var model = new R_ModelChangesViewModel()
			{
				IdSeccion = SeccionId,
				TituloSeccion = historyPagesInf.PageTitle,
				Tipo = Tipo,
			};

			//_lModelFeaturesRecordReport = model;

			return Redirect("/FactoryPlatform/Reports/ModelChanges");
		}

		public IActionResult ModelChanges()
		{
			var action = (HttpContext.Request.RouteValues.Values).Last();

			var model = new R_ModelChangesViewModel();
			//model = _lModelFeaturesRecordReport;
			//_lModelFeaturesRecordReport = new R_ModelChangesViewModel();

			var UserInfo = _lUsers.getIdUser(User).First();


			if (model.IdSeccion > 0)
			{

				ViewData["Titulo"] = model.TituloSeccion;

				var query = _lModelFeaturesRecord.GetModelFeature(UserInfo.Id_Usuario, UserInfo.PlantaId);

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
						//model = _lModelFeaturesRecord.GetModelFeature(UserInfo.Id_Usuario, UserInfo.PlantaId);

						ViewData["Titulo"] = select.First().PageTitle;
						model.TituloSeccion = select.First().PageTitle;
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

		//==========================================Model Feature Matrix =========================================================================================
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ModelFeatureMatrix(int SeccionId, int Tipo)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, UserInfo.Id_Usuario, Tipo);

			var model = new R_ModelFeatureMatrixViewModel()
			{
				IdSeccion = SeccionId,
				TituloSeccion = historyPagesInf.PageTitle,
				Tipo = Tipo,
			};

			_lModelFeatureMatrixLibrary = model;

			return Redirect("/FactoryPlatform/Reports/ModelFeatureMatrix");
		}

		public IActionResult ModelFeatureMatrix()
		{
			var action = (HttpContext.Request.RouteValues.Values).Last();

			var model = new R_ModelFeatureMatrixViewModel();
			model = _lModelFeatureMatrixLibrary;
			_lModelFeatureMatrixLibrary = new R_ModelFeatureMatrixViewModel();

			var UserInfo = _lUsers.getIdUser(User).First();


			if (model.IdSeccion > 0)
			{

				ViewData["Titulo"] = model.TituloSeccion;

				var query = _lModelFeatureMatrix.GetModelMatrix(UserInfo.Id_Usuario, UserInfo.PlantaId);

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
						model = _lModelFeatureMatrix.GetModelMatrix(UserInfo.Id_Usuario, UserInfo.PlantaId);

						ViewData["Titulo"] = select.First().PageTitle;
						model.TituloSeccion = select.First().PageTitle;
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
	}
}
