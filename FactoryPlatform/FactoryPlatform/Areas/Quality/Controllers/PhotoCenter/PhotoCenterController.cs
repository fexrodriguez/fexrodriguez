using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.Quality.Models.PhotoCenter;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.EJ2.Diagrams;
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
    public class PhotoCenterController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private readonly LUsers _lUsers;
        private readonly LHistorySetionsPagesUsers _lHistoryPages;
        public static PhotoCenterBeforeProofViewModel _PhotoCenterBeforeProof = new PhotoCenterBeforeProofViewModel();
		public static PhotocenterViewModel _PhotoCenterPacking = new PhotocenterViewModel();

        public static string valida_path = string.Empty;
        public static string valida_name = string.Empty;
        public static string valida_serie = string.Empty;
        public static string valida_station = string.Empty;
        public PhotoCenterController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lUsers = new LUsers(appContext);
            _lHistoryPages = new LHistorySetionsPagesUsers(fpContext, spContext);
        }


        //====================================PhotoCenter====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterBeforeProof(int SeccionId, int Tipo)
        {
            var model = new PhotoCenterBeforeProofViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotoCenterBeforeProofViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterBeforeProof = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterBeforeProof");
        }

        public IActionResult PhotoCenterBeforeProof()
        {
            var model = new PhotoCenterBeforeProofViewModel();
            model = _PhotoCenterBeforeProof;
            _PhotoCenterBeforeProof = new PhotoCenterBeforeProofViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
		//========================================================================================================================

		

		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidateModel(string serie, int station, int IdSeccion)
        {
            string jsonListaDatos = "";
            var UserInf = _lUsers.getIdUser(User).ToList();
            var query = _spContext.spFPAPP_PhotoCenter_ValidateStopModel.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Serie=@Serie, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @EstacionID=@EstacionID, @PlantaID = @PlantaID",
                new object[]
                {
                    new SqlParameter("Serie", serie),
                    new SqlParameter("EstacionID", station),
                    new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
                    new SqlParameter("PlantaID", UserInf.First().PlantaId),
                    new SqlParameter("ProcesoID", 1)
                }).AsNoTracking().ToList();
            if (query.Count > 0)
            {
                jsonListaDatos = JsonConvert.SerializeObject(query.First());
                return Ok(jsonListaDatos);
            }
            else
            {
                return Ok("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FTPUpload(IFormFile file, string Serie, int Station, string IdSeccion, string Modelo)
        {
            List<string> files = new List<string>();
            var UserInf = _lUsers.getIdUser(User).ToList();
            string error = "";
            var user = "";
            var passworda = "";

            var store = _spContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
            new object[]
            {
                new SqlParameter("UserID", UserInf.First().Id_Usuario)
            }).AsNoTracking().ToList();

            if (store.Count > 0)
            {
                var model = store.First();
                user = model.Usuario;
                passworda = model.Password;
            }

			//change this in production this only for tests
			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/photo-center/";
			valida_name = Serie;
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/photo-center/", Serie);
            
            Response.Clear();
            error = null;
			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/";
			valida_name = $"Proof{Station}";
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/", $"Proof{Station}");
            
            Response.Clear();
            error = null;

			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/Proof{Station}/";
			valida_name = "large";
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/Proof{Station}/", "large");
            

            if (error != "" && error != null)
            {
                if (error == "ExistsFolder")
                {
                    Response.Clear();
                    error = null;
                    
                    valida_serie = Serie;
                    valida_station = $"{Station}";


                    await Upload(Serie, $"{Station}");
                    if (error != "" && error != null)
                    {
                        error = null;
                        Response.Clear();
                        return BadRequest("Fail to upload the Photo.");
                    }
                    else
                    {
                        Response.Clear();
                        var query = _spContext.spFPAPP_PhotoCenter_Insert_MotorsMultiplant.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Serie=@Serie, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @EstacionID=@EstacionID, @PlantaID=@PlantaID, @Modelo=@Modelo",
                        new object[]
                        {
                            new SqlParameter("Serie", Serie),
                            new SqlParameter("EstacionID", Station),
                            new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
                            new SqlParameter("PlantaID", UserInf.First().PlantaId),
							new SqlParameter("Modelo", Modelo==null?"-":Modelo),
							new SqlParameter("ProcesoID", 2)
                        }).AsNoTracking().ToList();

                        return Ok("success");
                    }
                }
                else
                {
                    return BadRequest("Fail to upload the Photo please contac the Admin.");
                }
            }
            else
            {
                await Upload(Serie, $"{Station}");
                if (error != "" && error != null)
                {
                    error = null;
                    Response.Clear();
                    return BadRequest("Fail to upload the Photo.");
                }
                else
                {
                    Response.Clear();

                    var query = _spContext.spFPAPP_PhotoCenter_Insert_MotorsMultiplant.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Serie=@Serie, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @EstacionID=@EstacionID, @PlantaID=@PlantaID, @Modelo=@Modelo",
                       new object[]
                       {
                            new SqlParameter("Serie", Serie),
                            new SqlParameter("EstacionID", Station),
                            new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
                            new SqlParameter("PlantaID", UserInf.First().PlantaId),
							new SqlParameter("Modelo", Modelo==null?"":Modelo),
							new SqlParameter("ProcesoID", 2)
                       }).AsNoTracking().ToList();

                    return Ok("success");
                }
            }

            async Task Create(string path, string name)
            {
                string validated_path_host = valida_path;
                string validated_name_host = valida_name;

                if (path.Equals(validated_path_host) && name.Equals(validated_name_host))
                {
                    string url = $"ftp://10.208.122.234/{validated_path_host}{validated_name_host}";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uriResult);
                        try
                        {
                            FileManagerResponse createResponse = new FileManagerResponse();
                            try
                            {

                                request.Credentials = new NetworkCredential(user, passworda);
                                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                                Stream responseStream = response.GetResponseStream();
                                StreamReader reader = new StreamReader(responseStream);
                            
                                reader.ReadToEnd();
                                reader.Close();
                                response.Close();
                                responseStream.Close();
                            }
                            catch (WebException e)
                            {
                                ErrorDetails er = new ErrorDetails();
                                FtpWebResponse response = (FtpWebResponse)e.Response;
                                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable && response.StatusDescription.Contains("exists"))
                                {

                                }
                                else
                                {
                                    er.Code = "417";
                                    er.Message = response.StatusDescription;
                                }
                                response.Close();
                            }

                            FileManagerDirectoryContent createData = new FileManagerDirectoryContent();
                            createData.Name = name;
                            createData.IsFile = false;
                            createData.Size = 0;
                            createData.DateModified = DateTime.Now;
                            createData.DateCreated = createData.DateModified;
                            createData.HasChild = false;
                            createData.Type = "";
                            FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { createData };
                        }
                        catch (Exception e)
                        {
                            error = e.Message.ToString();
                    }
                    }
                }
            }

            async Task Upload(string Serie,string Station)
            {
                string validated_serie_host = valida_serie;
                string validated_station_host = valida_station;

                if (Serie.Equals(validated_serie_host) && Station.Equals(validated_station_host))
                {
                    string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/photo-center/{validated_serie_host}/Proof{validated_station_host}/large";
                    Uri uriResult;
                    bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uriResult);
                        try
                        {
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
                                error = ex.Message.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            error = ex.Message.ToString();
                        }
                    }
                    var CountFiles = files.Count + 1;
                    string name = $"{Serie}-{CountFiles}{Path.GetExtension(file.FileName)}";
                    string urls = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/Proof{Station}/large/{name}";
                    result = Uri.TryCreate(urls, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
                    if (result == true)
                    {
                        FtpWebRequest solcitud = (FtpWebRequest)FtpWebRequest.Create(uriResult);
                    try
                    {
                        //FtpWebRequest solcitud = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/photo-center/{Serie}/Proof{Station}/large/{name}");
                        solcitud.Credentials = new NetworkCredential(user, passworda);
                        solcitud.Method = WebRequestMethods.Ftp.UploadFile;
                        try
                        {
                            using (Stream stream = solcitud.GetRequestStream())
                            {
                                file.CopyTo(stream);
                            }
                        }
                        catch (Exception e)
                        {
                            ErrorDetails er = new ErrorDetails();
                            error = e.Message.ToString();
                        }
                    }
                    catch (Exception e)
                    {
                        error = e.Message.ToString();
                    }
                    }
                }
            }

        }
		//========================================================================================================================
		//====================================PhotoCenter Packing====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterPacking(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterPacking");
		}

		public IActionResult PhotoCenterPacking()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}
		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult ValidateInternalServices(string serie, int station, int IdSeccion)
		{
			string jsonListaDatos = "";
			var UserInf = _lUsers.getIdUser(User).ToList();
			var query = _spContext.ExecStores.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Serie=@Serie, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @EstacionID=@EstacionID, @PlantaID = @PlantaID",
				new object[]
				{
					new SqlParameter("Serie", serie),
					new SqlParameter("EstacionID", station),
					new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
					new SqlParameter("PlantaID", UserInf.First().PlantaId),
					new SqlParameter("ProcesoID", 3)
				}).AsNoTracking().ToList();
			if (query.Count > 0)
			{
				jsonListaDatos = JsonConvert.SerializeObject(query.First());
				return Ok(jsonListaDatos);
			}
			else
			{
				return Ok("Error");
			}
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult ValidateStopModel(string modelo)
		{
			string jsonListaDatos = "";
			var UserInf = _lUsers.getIdUser(User).ToList();
			var query = _spContext.spFPAPP_PhotoCenter_ValidateStopModel.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Modelo=@Modelo, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @PlantaID = @PlantaID",
				new object[]
				{
					new SqlParameter("Modelo", modelo),
					new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
					new SqlParameter("PlantaID", UserInf.First().PlantaId),
					new SqlParameter("ProcesoID", 4)
				}).AsNoTracking().ToList();
			if (query.Count > 0)
			{
				jsonListaDatos = JsonConvert.SerializeObject(query.First());
				return Ok(jsonListaDatos);
			}
			else
			{
				return Ok("Error");
			}
		}
		//========================================================================================================================
		//====================================PhotoCenter Packing====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterRackPinion(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterRackPinion");
		}

		public IActionResult PhotoCenterRackPinion()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}


		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public IActionResult ValidateBeforeProof(string serie, int station, int IdSeccion)
		//{
		//	string jsonListaDatos = "";
		//	var UserInf = _lUsers.getIdUser(User).ToList();
		//	var query = _spContext.spFPAPP_PhotoCenter_ValidateStopModel.FromSqlRaw("EXEC spFPAPP_PhotoCenter @Serie=@Serie, @UsuarioID=@UsuarioID, @ProcesoID=@ProcesoID, @EstacionID=@EstacionID, @PlantaID = @PlantaID",
		//		new object[]
		//		{
		//			new SqlParameter("Serie", serie),
		//			new SqlParameter("EstacionID", station),
		//			new SqlParameter("UsuarioID", UserInf.First().Id_Usuario),
		//			new SqlParameter("PlantaID", UserInf.First().PlantaId),
		//			new SqlParameter("ProcesoID", 5)
		//		}).AsNoTracking().ToList();
		//	if (query.Count > 0)
		//	{
		//		jsonListaDatos = JsonConvert.SerializeObject(query.First());
		//		return Ok(jsonListaDatos);
		//	}
		//	else
		//	{
		//		return Ok("Error");
		//	}
		//}
		//========================================================================================================================
		//====================================PhotoCenter Rear Axles====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterRearAxles(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterRearAxles");
		}

		public IActionResult PhotoCenterRearAxles()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}
		//========================================================================================================================
		//====================================PhotoCenter Turbo Charger====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterTurboCharger(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterTurboCharger");
		}

		public IActionResult PhotoCenterTurboCharger()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}
        //========================================================================================================================
        //====================================PhotoCenter Ensamble Rear Axles ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterAssemblyRearAxles(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterAssemblyRearAxles");
        }

        public IActionResult PhotoCenterAssemblyRearAxles()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Ensamble Turbo Charger====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterAssemblyTurboCharger(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterAssemblyTurboCharger");
        }

        public IActionResult PhotoCenterAssemblyTurboCharger()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Inspeccion Cabeza V.S.====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterInspectionHeads(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterInspectionHeads");
        }

        public IActionResult PhotoCenterInspectionHeads()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================

        //====================================PhotoCenter Pintura ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterPaint(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterPaint");
        }

        public IActionResult PhotoCenterPaint()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Prueba de MOTOR HT ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterEngineTestHT(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterEngineTestHT");
        }

        public IActionResult PhotoCenterEngineTestHT()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Prueba de MOTOR SIM ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterEngineSIM(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterEngineSIM");
        }

        public IActionResult PhotoCenterEngineSIM()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================

        //====================================PhotoCenter Prueba de MOTOR RMC ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterEngineRMC(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterEngineRMC");
        }

        public IActionResult PhotoCenterEngineRMC()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Prueba de Rack and Pinion ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterTestRackPinion(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterTestRackPinion");
        }

        public IActionResult PhotoCenterTestRackPinion()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
        //========================================================================================================================
        //====================================PhotoCenter Prueba de Turbos ====================================================================================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PhotoCenterTestTurboCharger(int SeccionId, int Tipo)
        {
            var model = new PhotocenterViewModel();
            var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

            var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

            model = new PhotocenterViewModel()
            {
                IdSeccion = historyPagesInf.IdSection,
                TituloSeccion = historyPagesInf.PageTitle,
                Station = historyPagesInf.PageId,
                Tipo = Tipo
            };

            _PhotoCenterPacking = model;

            return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterTestTurboCharger");
        }

        public IActionResult PhotoCenterTestTurboCharger()
        {
            var model = new PhotocenterViewModel();
            model = _PhotoCenterPacking;
            _PhotoCenterPacking = new PhotocenterViewModel();

            var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
                  new SqlParameter("UserID", idUsuario),
                  new SqlParameter("Operation", 6)
               }).AsNoTracking().ToList();


                if (select.Count > 0)
                {
                    ViewData["Titulo"] = select.First().PageTitle;
                    model.Station = select.First().PageID;
                    model.IdSeccion = select.First().IdSection;
                    model.Tipo = select.First().Tipo;
                    return View(model);
                }
                else
                {
                    return Redirect("/FactoryPlatform/Sections/Pages");
                }
            }
        }
		//========================================================================================================================
		//====================================PhotoCenter Servicio Interno ====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterInternalServices(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterInternalServices");
		}

		public IActionResult PhotoCenterInternalServices()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}
		//========================================================================================================================
		//====================================PhotoCenter Tinware ====================================================================================

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> PhotoCenterTinware(int SeccionId, int Tipo)
		{
			var model = new PhotocenterViewModel();
			var IdUser = _lUsers.getIdUser(User).First().Id_Usuario;

			var historyPagesInf = await _lHistoryPages.CheckPagesHistory(SeccionId, IdUser, Tipo);

			model = new PhotocenterViewModel()
			{
				IdSeccion = historyPagesInf.IdSection,
				TituloSeccion = historyPagesInf.PageTitle,
				Station = historyPagesInf.PageId,
				Tipo = Tipo
			};

			_PhotoCenterPacking = model;

			return Redirect("/FactoryPlatform/PhotoCenter/PhotoCenterTinware");
		}

		public IActionResult PhotoCenterTinware()
		{
			var model = new PhotocenterViewModel();
			model = _PhotoCenterPacking;
			_PhotoCenterPacking = new PhotocenterViewModel();

			var idUsuario = _lUsers.getIdUser(User).First().Id_Usuario;

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
				  new SqlParameter("UserID", idUsuario),
				  new SqlParameter("Operation", 6)
			   }).AsNoTracking().ToList();


				if (select.Count > 0)
				{
					ViewData["Titulo"] = select.First().PageTitle;
					model.Station = select.First().PageID;
					model.IdSeccion = select.First().IdSection;
					model.Tipo = select.First().Tipo;
					return View(model);
				}
				else
				{
					return Redirect("/FactoryPlatform/Sections/Pages");
				}
			}
		}
		//========================================================================================================================
	}
}
