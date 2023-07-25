using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Areas.ServiceNow.Models;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl;
using System.Collections.Generic;
using System.IO;
using System;
using System.Net;
using System.Security.Policy;
using Azure;
using Syncfusion.EJ2.Linq;
using Microsoft.AspNetCore.Http;
using Syncfusion.EJ2.FileManager.Base;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FactoryPlatform.Areas.ServiceNow.Controllers.TaskMenu
{
    [Area("ServiceNow")]
    [ServiceFilter(typeof(ActionMethodServiceNowFilter), Order = 1)]
    public class TMAnpControlController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
		public static string valida_path = string.Empty;
		public static string valida_name = string.Empty;
		public static string valida_codigo = string.Empty;
		public static string valida_request = string.Empty;
		public TMAnpControlController(LKQMXFPAPPContext fpContext, ApplicationDbContext appContext, StoresProceduresDbContext SpContext)
        {
            _fpContext = fpContext;
            _SpContext = SpContext;
            _lUsers = new LUsers(appContext);
        }


        public class ModalInfo
        {
            public ReportAnpControlInformation InfoGeneral { get; set; } = new ReportAnpControlInformation();
            public List<ReportAnpControlInformationTable> InfoTable { get; set; } = new List<ReportAnpControlInformationTable>();
			public List<ReturnUpload> DocumentosList { get; set; } = new List<ReturnUpload>();

			public List<ReportAnpStep1Info> Step1Info { get; set; } = new List<ReportAnpStep1Info>();
			public List<ReportAnpStep1AttrInspection> Step1InfoAttrInspection { get; set; } = new List<ReportAnpStep1AttrInspection>();
			public List<ReportAnpStep1DimensionalInspect> Step1InfoDimensional { get; set; } = new List<ReportAnpStep1DimensionalInspect>();

			public List<ReportAnpStep1DimensionalSpecifications> Step1InfoDimensionalSpecifications { get; set; } = new List<ReportAnpStep1DimensionalSpecifications>();
			public List<AnpListUnits> AnpListUnits { get; set; } = new List<AnpListUnits>();
			public List<ReportAnpHistoryModal> ReportAnpHistoryModal { get; set; } = new List<ReportAnpHistoryModal>();

			public List<ReturnStepFiles> ReturnStepFiles { get; set; } = new List<ReturnStepFiles>();
			public List<ReturnStepFilesDoc> ReturnStepFilesDoc { get; set; } = new List<ReturnStepFilesDoc>();
			public List<AnpInfoWarranty> AnpInfoWarranty { get; set; } = new List<AnpInfoWarranty>();
			
		}

		public class ReturnUpload //Retornar resultado Json 
		{
			public string FileName { get; set; }
			public int Requisicion { get; set; }
			public int Articulo { get; set; }
			public int Proveedor { get; set; }
			public int PlantaId { get; set; }
		}

		public class ReturnStepFiles //Retornar resultado Json 
		{
			public string FileName { get; set; }
			public int PlantaId { get; set; }
		}
		public class ReturnStepFilesDoc //Retornar resultado Json 
		{
			public string FileName { get; set; }
			public int PlantaId { get; set; }
		}

		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReqInformation(int req)
        {
			var error = "";
			List<string> files = new List<string>();
			var Json = new List<ReturnUpload>();

			var UserInf = _lUsers.getIdUser(User).First();
            var jsonDatos = "";
            var model = new ModalInfo();
			var user = "";
			var passworda = "";
			


			var FirstQuery = _SpContext.ReportAnpControlInformation.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
            "@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RequestID=@RequestID",
            new object[]
            {
            new SqlParameter("Operacion", 2),
            new SqlParameter("Opcion", 1),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("@RequestID", req),
            }).AsNoTracking().ToList();

            if (FirstQuery.Any())
            {
                model.InfoGeneral = FirstQuery.First();
            }

            var SecondQuery = _SpContext.ReportAnpControlInformationTable.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
            "@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RequestID=@RequestID",
            new object[]
            {
            new SqlParameter("Operacion", 2),
            new SqlParameter("Opcion", 2),
            new SqlParameter("UsuarioID", UserInf.Id_Usuario),
            new SqlParameter("RequestID", req),
            }).AsNoTracking().ToList();

            if (SecondQuery.Any())
            {
                model.InfoTable = SecondQuery;
            }

			var query = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
			   new object[]
			   {
					new SqlParameter("UserID", UserInf.Id_Usuario)
			   }).AsNoTracking().ToList();

			if (query.Count > 0)
			{
				var models = query.First();

				user = models.Usuario;
				passworda = models.Password;
			}

			FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create($"ftp://10.208.122.234/documentcenter/Planta{UserInf.PlantaId}/anp-center/{model.InfoGeneral.ID_Request}/{model.InfoGeneral.ArticuloID}/{model.InfoGeneral.ProveedorID}");
			request.Credentials = new NetworkCredential(user, passworda);
			request.Method = WebRequestMethods.Ftp.ListDirectory;

			// Extract the hostname from the URL
			if(request.RequestUri.Host == "10.208.122.234")
			{
				try
				{
					FtpWebResponse response = (FtpWebResponse)request.GetResponse();
					Stream responseStream = response.GetResponseStream();
					StreamReader reader = new StreamReader(responseStream);

					var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

					if (ftpFiles.Count > 0)
					{
						files = ftpFiles;

						foreach (var name in files)
						{
							Json.Add(new ReturnUpload
							{
								FileName = name,
								Requisicion = (int)model.InfoGeneral.ID_Request,
								Articulo = (int)model.InfoGeneral.ArticuloID,
								Proveedor = (int)model.InfoGeneral.ProveedorID,
								PlantaId = UserInf.PlantaId
							});



						}
						model.DocumentosList = Json;
					}
					ftpFiles.Clear();
                    responseStream.Close();
					reader.Close();
                    response.Close();
                }
				catch (Exception ex)
				{
					error = ex.Message;

				}

				jsonDatos = JsonConvert.SerializeObject(model);

				return Ok(jsonDatos);
			}
			else
			{
				return BadRequest();
			}

			


        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult assingEngineer(int Engineerid, int Requestid)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @RequestID=@RequestID, @UsuarioAsignadoID=@UsuarioAsignadoID",
			new object[]
			{
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 1),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RequestID", Requestid),
			new SqlParameter("UsuarioAsignadoID", Engineerid),

			}).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult saveStepCero(string Comment, int ReqID)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @RequestID=@RequestID, @Comentarios=@Comentarios",
			new object[]
			{
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 2),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RequestID", ReqID),
			new SqlParameter("Comentarios", Comment),

			}).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult reasingTask(int UsuarioID, int RequestID, string Comment ,int Nivel)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @RequestID=@RequestID, @UsuarioAsignadoID=@UsuarioAsignadoID , @Comentarios=@Comentarios , @Nivel=@Nivel",
			new object[]
			{
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 3),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RequestID", RequestID),
			new SqlParameter("UsuarioAsignadoID", UsuarioID),
			new SqlParameter("Comentarios", Comment),
			new SqlParameter("Nivel", Nivel),
			}).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult getModalStep1(int RequestID,int Nivel, string CodigoMedio)
		{
			var error = "";
			var UserInf = _lUsers.getIdUser(User).First();
			var jsonDatos = "";
			var model = new ModalInfo();
			List<string> files = new List<string>();
			var Json = new List<ReturnStepFiles>();
			var JsonDoc = new List<ReturnStepFilesDoc>();
			var user = "";
			var passworda = "";


			var FirstQuerys = _SpContext.ReportAnpStep1Info.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RequestID=@RequestID",
			new object[]
			{
			new SqlParameter("Operacion", 1),
			new SqlParameter("Opcion", 2),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("@RequestID", RequestID),
			}).AsNoTracking().ToList();

			if (FirstQuerys.Any())
			{
				model.Step1Info = FirstQuerys;	
			}

			var FanpId = model.Step1Info.Select(l => l.ID_FANP).ToArray().First();
			var RegistroEntradaId = model.Step1Info.Select(l => l.ID_RegistroEntrada).ToArray().First();
			if(RegistroEntradaId == null) { RegistroEntradaId = 0; }

			if (FanpId != null && RegistroEntradaId > 0)
			{
				var SecondQuery = _SpContext.ReportAnpStep1DimensionalInspect.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RegistroEntradaID=@RegistroEntradaID, @FanpID=@FanpID, @RequestID=@RequestID",
				new object[]
				{
				new SqlParameter("Operacion", 1),
				new SqlParameter("Opcion", 3),
				new SqlParameter("UsuarioID", UserInf.Id_Usuario),
				new SqlParameter("RegistroEntradaID", RegistroEntradaId),
				new SqlParameter("FanpID", FanpId),
				new SqlParameter("RequestID", RequestID),
				}).AsNoTracking().ToList();

				if (SecondQuery.Any())
				{
					model.Step1InfoDimensional = SecondQuery;
				}
			}

			if (FanpId != null) { 
			var ThreeQuery = _SpContext.ReportAnpStep1AttrInspection.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RegistroEntradaID=@RegistroEntradaID, @FanpID=@FanpID, @RequestID=@RequestID",
			new object[]
			{
			new SqlParameter("Operacion", 1),
			new SqlParameter("Opcion", 4),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RegistroEntradaID", RegistroEntradaId),
			new SqlParameter("FanpID", FanpId),
			new SqlParameter("RequestID", RequestID),
			}).AsNoTracking().ToList();

				if (ThreeQuery.Any())
				{
					model.Step1InfoAttrInspection = ThreeQuery;
				}
			}

			if (FanpId != null)
			{
				var FourthQuery = _SpContext.ReportAnpStep1DimensionalSpecifications.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RegistroEntradaID=@RegistroEntradaID, @FanpID=@FanpID, @RequestID=@RequestID",
				new object[]
				{
			new SqlParameter("Operacion", 1),
			new SqlParameter("Opcion", 5),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RegistroEntradaID", RegistroEntradaId),
			new SqlParameter("FanpID", FanpId),
			new SqlParameter("RequestID", RequestID),
				}).AsNoTracking().ToList();

				if (FourthQuery.Any())
				{
					model.Step1InfoDimensionalSpecifications = FourthQuery;
				}
			}


			if (FanpId != null)
			{
				var FiveQuery = _SpContext.AnpListUnits.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID",
				new object[]
				{
			new SqlParameter("Operacion", 3),
			new SqlParameter("Opcion", 3),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
				}).AsNoTracking().ToList();

				if (FiveQuery.Any())
				{
					model.AnpListUnits = FiveQuery;
				}
			}


			var SixQuery = _SpContext.ReportAnpHistoryModal.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RequestID=@RequestID, @Nivel=@Nivel",
				new object[]
				{
			new SqlParameter("Operacion", 3),
			new SqlParameter("Opcion", 4),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RequestID", RequestID),
			new SqlParameter("Nivel", Nivel),
				}).AsNoTracking().ToList();

			if (SixQuery.Any())
			{
				model.ReportAnpHistoryModal = SixQuery;
			}

			if (FanpId != null && RegistroEntradaId > 0)
			{
				var SevenQuery = _SpContext.AnpInfoWarranty.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				"@Operacion=@Operacion, @Opcion=@Opcion, @UsuarioID=@UsuarioID, @RegistroEntradaID=@RegistroEntradaID, @FanpID=@FanpID, @RequestID=@RequestID",
				new object[]
				{
				new SqlParameter("Operacion", 1),
				new SqlParameter("Opcion", 6),
				new SqlParameter("UsuarioID", UserInf.Id_Usuario),
				new SqlParameter("RegistroEntradaID", RegistroEntradaId),
				new SqlParameter("FanpID", FanpId),
				new SqlParameter("RequestID", RequestID),
				}).AsNoTracking().ToList();

				if (SevenQuery.Any())
				{
					model.AnpInfoWarranty = SevenQuery;
				}
			}

			var query = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
			   new object[]
			   {
					new SqlParameter("UserID", UserInf.Id_Usuario)
			   }).AsNoTracking().ToList();

			if (query.Count > 0)
			{
				var models = query.First();

				user = models.Usuario;
				passworda = models.Password;
			}


			string url = ($"ftp://10.208.122.234/photocenter/Planta{UserInf.PlantaId}/fanp/{CodigoMedio}/{RequestID}/Step{Nivel}/");
			Uri uriResult;
			bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
				&& (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
			if (result == true)
			{
				

				try
				{
					FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uriResult);
					
					request.Method = WebRequestMethods.Ftp.ListDirectory;
					request.Credentials = new NetworkCredential(user, passworda);

					FtpWebResponse response = (FtpWebResponse)request.GetResponse();
					Stream responseStream = response.GetResponseStream();
					StreamReader reader = new StreamReader(responseStream);

					var ftpFiles = reader.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();

					if (ftpFiles.Count > 0)
					{
						files = ftpFiles;

						foreach (var name in files)
						{

							if (new string[] { ".png", ".jpg", ".jpeg"}.Any(s => name.ToLower().Contains(s))) { 

							Json.Add(new ReturnStepFiles
							{
								FileName = name,
								PlantaId = UserInf.PlantaId
							});

							}
							else
							{
								JsonDoc.Add(new ReturnStepFilesDoc
								{
									FileName = name,
									PlantaId = UserInf.PlantaId
								});
							}

						}
						model.ReturnStepFiles = Json;
						model.ReturnStepFilesDoc = JsonDoc;
					}

					response.Close();
					responseStream.Close();
					reader.Close();
				}
				catch (Exception ex)
				{
					error = ex.Message;
				}

			}
			else
			{
				error = "Url Invalida";
			}

	

			if (FirstQuerys.Any())
			{
				

				jsonDatos = JsonConvert.SerializeObject(model);

				return Ok(jsonDatos);
			}
			else
			{
				return BadRequest();
			}




		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpdateDimensionalInspection(int id, int nivel, string unidad, string minimo, string maximo, string medicion,string conclusion)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
		   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Nivel=@Nivel, @Unidad=@Unidad , @Minimo=@Minimo , @Maximo=@Maximo, @Medicion=@Medicion, @Conclusion=@Conclusion, @RegistroID=@RegistroID",
		   new object[]
		   {
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 5),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("Nivel", nivel),
			new SqlParameter("Unidad", unidad),
			new SqlParameter("Minimo", minimo),
			new SqlParameter("Maximo", maximo),
			new SqlParameter("Medicion", medicion),
			new SqlParameter("Conclusion", conclusion),
			new SqlParameter("RegistroID", id),
		   }).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}

		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpdateGeneralAttr(string resultado, string conclusion, int id)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			 var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Resultado=@Resultado, @Conclusion=@Conclusion , @RegistroID=@RegistroID ",
			new object[]
			{
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 4),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("Resultado", resultado),
			new SqlParameter("Conclusion", conclusion),
			new SqlParameter("RegistroID", id),
			}).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpdateDimensionalSpec(int id, int nivel, string unidad, string minimo, string maximo)
		{
			var UserInf = _lUsers.getIdUser(User).First();

			var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
		   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Nivel=@Nivel, @Unidad=@Unidad , @Minimo=@Minimo , @Maximo=@Maximo, @RegistroID=@RegistroID",
		   new object[]
		   {
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 6),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("Nivel", nivel),
			new SqlParameter("Unidad", unidad),
			new SqlParameter("Minimo", minimo),
			new SqlParameter("Maximo", maximo),
			new SqlParameter("RegistroID", id),
		   }).AsNoTracking().ToList();

			if (Query.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}

		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult saveStep1Data(string Aplicacion, int Serivicio, string Comentarios, int RequestID, int Fanp, int Nivel)
		{
			var UserInf = _lUsers.getIdUser(User).First();

				var Query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
				  "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Aplicacion=@Aplicacion, @ServicioInterno=@ServicioInterno , @Comentarios=@Comentarios , @RequestID=@RequestID , @FanpID=@FanpID , @Nivel=@Nivel ",
				  new object[]
				  {
				new SqlParameter("Operacion", 4),
				new SqlParameter("Opcion", 7),
				new SqlParameter("UsuarioID", UserInf.Id_Usuario),
				new SqlParameter("Aplicacion", Aplicacion),
				new SqlParameter("ServicioInterno", Serivicio),
				new SqlParameter("Comentarios", Comentarios),
				new SqlParameter("RequestID", RequestID),
				new SqlParameter("FanpID", Fanp),
				new SqlParameter("Nivel", Nivel),
				  }).AsNoTracking().ToList();

				if (Query.Any())
				{
					return Ok("Success");
				}
				else
				{
					return Ok("Error");
				}
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult saveStep1Nivel1(int CaracteristicaId, string Caracteristica, string Unidad, string Minimo, string Maximo, string Medicion, string Conclusion , int Update, int RequestID, int Fanp, int Tipo, int Nivel)
		{
			var UserInf = _lUsers.getIdUser(User).First();
			//return Ok("Success");
			var Querya = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			  "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Conclusion=@Conclusion , @CaracteristicaID=@CaracteristicaID , @Caracteristica=@Caracteristica,  " +
			  "@Unidad=@Unidad , @Minimo=@Minimo , @Maximo=@Maximo , @Medicion=@Medicion  , @UpdateInfo=@UpdateInfo , @RequestID=@RequestID , @FanpID=@FanpID   , @Tipo=@Tipo  , @Nivel=@Nivel  ",
			  new object[]
			  {
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 7),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("CaracteristicaID", CaracteristicaId),
			new SqlParameter("Caracteristica", Caracteristica = Caracteristica != null ? Caracteristica : "-"),
			new SqlParameter("Unidad", Unidad),
			new SqlParameter("Minimo", Minimo),
			new SqlParameter("Maximo", Maximo),
			new SqlParameter("Medicion", Medicion),
			new SqlParameter("Conclusion", Conclusion),
			new SqlParameter("UpdateInfo", Update),
			new SqlParameter("RequestID", RequestID),
			new SqlParameter("FanpID", Fanp),
			new SqlParameter("Tipo", Tipo),
			new SqlParameter("Nivel", Nivel),
			  }).AsNoTracking().ToList();

			if (Querya.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult saveStep1Nivel2(int CaracteristicaId, string Caracteristica, string Resultado, string Conclusion, int Update, int RequestID, int Fanp, int Tipo, int Nivel)
		{
			var UserInf = _lUsers.getIdUser(User).First();
			//return Ok("Success");
			var Queryk = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			  "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @Resultado=@Resultado, @Conclusion=@Conclusion, @CaracteristicaID=@CaracteristicaID, @Caracteristica=@Caracteristica, @RequestID=@RequestID, @FanpID=@FanpID, @Nivel=@Nivel, @Tipo=@Tipo, @UpdateInfo=@UpdateInfo ",
			  new object[]
			  {
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 7),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("RequestID", RequestID),
			new SqlParameter("Caracteristica", Caracteristica = Caracteristica != null ? Caracteristica : "-"),
			new SqlParameter("CaracteristicaID", CaracteristicaId),
			new SqlParameter("Resultado", Resultado),
			new SqlParameter("Conclusion", Conclusion),
			new SqlParameter("FanpID", Fanp),
			new SqlParameter("UpdateInfo", Update),
			new SqlParameter("Tipo", Tipo),
			new SqlParameter("Nivel", Nivel),
			  }).AsNoTracking().ToList();

			if (Queryk.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult saveStep1Nivel3(int CaracteristicaId, string Caracteristica,string Unidad, string Minimo, string Maximo, int Update, int RequestID, int Fanp, int Tipo, int Nivel)
		{
			var UserInf = _lUsers.getIdUser(User).First();
			//return Ok("Success");
			var Querys = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Services_now_Anp_Control " +
			  "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @Opcion=@Opcion, @CaracteristicaID=@CaracteristicaID, @Caracteristica=@Caracteristica,  " +
			  "@Unidad=@Unidad, @Minimo=@Minimo, @Maximo=@Maximo, @UpdateInfo=@UpdateInfo, @RequestID=@RequestID, @FanpID=@FanpID, @Tipo=@Tipo, @Nivel=@Nivel  ",
			  new object[]
			  {
			new SqlParameter("Operacion", 4),
			new SqlParameter("Opcion", 7),
			new SqlParameter("UsuarioID", UserInf.Id_Usuario),
			new SqlParameter("CaracteristicaID", CaracteristicaId),
			new SqlParameter("Caracteristica", Caracteristica = Caracteristica != null ? Caracteristica : "-"),
			new SqlParameter("Unidad", Unidad),
			new SqlParameter("Minimo", Minimo),
			new SqlParameter("Maximo", Maximo),
			new SqlParameter("UpdateInfo", Update),
			new SqlParameter("RequestID", RequestID),
			new SqlParameter("FanpID", Fanp),
			new SqlParameter("Tipo", Tipo),
			new SqlParameter("Nivel", Nivel),
			  }).AsNoTracking().ToList();

			if (Querys.Any())
			{
				return Ok("Success");
			}
			else
			{
				return Ok("Error");
			}
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> FTPUpload(IFormFile file, int RequestID, string CodigoMedio,int Nivel)
		{
			List<string> files = new List<string>();
			var UserInf = _lUsers.getIdUser(User).ToList();
			string error = "";
			var user = "";
			var passworda = "";

			var store = _SpContext.spFPAPP_Sys_FtpCredencials.FromSqlRaw("EXEC spFPAPP_Sys_FtpCredencials @UserID = @UserID",
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
			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/fanp/";
			valida_name = CodigoMedio;
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/fanp/", CodigoMedio);
			
			Response.Clear();
			error = null;
			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/fanp/{CodigoMedio}/";
			valida_name = $"{RequestID}";
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/fanp/{CodigoMedio}/", $"{RequestID}");
			
			Response.Clear();
			error = null;

			valida_path = $"photocenter/Planta{UserInf.First().PlantaId}/fanp/{CodigoMedio}/{RequestID}/";
			valida_name = $"Step{Nivel}";
			await Create($"photocenter/Planta{UserInf.First().PlantaId}/fanp/{CodigoMedio}/{RequestID}/", $"Step{Nivel}");

			valida_codigo = CodigoMedio;
			valida_request = $"{RequestID}";

			if (error != "" && error != null)
			{
				if (error == "ExistsFolder")
				{
					Response.Clear();
					error = null;

					valida_codigo = CodigoMedio;
					valida_request = $"{RequestID}";


					await Upload(CodigoMedio, $"{RequestID}", $"{Nivel}");
					if (error != "" && error != null)
					{
						error = null;
						Response.Clear();
						return BadRequest("Fail to upload the Photo.");
					}
					else
					{
						Response.Clear();
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
				await Upload(CodigoMedio, $"{RequestID}", $"{Nivel}");
				if (error != "" && error != null)
				{
					error = null;
					Response.Clear();
					return BadRequest("Fail to upload the Photo.");
				}
				else
				{
					Response.Clear();
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

			async Task Upload(string CodigoMedio, string RequestID,string Nivel)
			{
				string validated_codigo_host = valida_codigo;
				string validated_request_host = valida_request;

				if (CodigoMedio.Equals(validated_codigo_host) && RequestID.Equals(validated_request_host))
				{
					string url = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/fanp/{validated_codigo_host}/{validated_request_host}/Step{Nivel}";
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
					string name = $"{CountFiles}-{file.FileName}";
					string urls = $"ftp://10.208.122.234/photocenter/Planta{UserInf.First().PlantaId}/fanp/{validated_codigo_host}/{validated_request_host}/Step{Nivel}/{name}";
					result = Uri.TryCreate(urls, UriKind.Absolute, out uriResult)
						&& (uriResult.Scheme == Uri.UriSchemeFtp || uriResult.Scheme == Uri.UriSchemeFtp);
					if (result == true)
					{
						FtpWebRequest solcitud = (FtpWebRequest)FtpWebRequest.Create(uriResult);
						try
						{
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
	}
}
