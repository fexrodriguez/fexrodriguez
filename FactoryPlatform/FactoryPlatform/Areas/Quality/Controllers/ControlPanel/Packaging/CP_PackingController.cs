using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelSequences;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Models;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.Packaging
{
	[Area("Quality")]
	[ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
	public class CP_PackingController : Controller
	{
		private LKQMXFPAPPContext _fpContext;
		private StoresProceduresDbContext _SpContext;
		private readonly LUsers _lUsers;
		private readonly LModels _lModels;

		public CP_PackingController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
		{
			_fpContext = fpContext;
			_SpContext = spContext;
			_lUsers = new LUsers(appContext);
			_lModels = new LModels(spContext);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult saveNewOption(string Numero, string Descripcion, int Opcion)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";
			//var model = new ReturnInsert();
			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@Numero=@Numero,@Descripcion=@Descripcion ",
			   new object[]
			   {
					new SqlParameter("Operacion", 14),
					new SqlParameter("Opcion", Opcion),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Numero", Numero),
					new SqlParameter("Descripcion", Descripcion)
			   }).AsNoTracking().ToList();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{
				if (query.Any())
				{

					Json = JsonConvert.SerializeObject(query);
				}
			}
			else
			{
				Json = "Error";
			}

			return Ok(Json);
		}


		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Delete(int IDRegistro, int Opcion)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";
			//var model = new ReturnInsert();
			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@RegistroID=@RegistroID ",
			   new object[]
			   {
					new SqlParameter("Operacion", 17),
					new SqlParameter("Opcion", Opcion),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("RegistroID", IDRegistro)
			   }).AsNoTracking().ToList();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{
				if (query.Any())
				{

					Json = JsonConvert.SerializeObject(query);
				}
			}
			else
			{
				Json = "Error";
			}

			return Ok(Json);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult EditOption(string Numero, string Descripcion, int Opcion, int RegistroID)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";
			//var model = new ReturnInsert();
			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@Numero=@Numero,@Descripcion=@Descripcion,@RegistroID=@RegistroID ",
			   new object[]
			   {
					new SqlParameter("Operacion", 18),
					new SqlParameter("Opcion", Opcion),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Numero", Numero),
					new SqlParameter("Descripcion", Descripcion),
					new SqlParameter("RegistroID", RegistroID)
			   }).AsNoTracking().ToList();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{
				if (query.Any())
				{

					Json = JsonConvert.SerializeObject(query);
				}
			}
			else
			{
				Json = "Error";
			}

			return Ok(Json);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult Locked(int Opcion, int RegistroID)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";
			//var model = new ReturnInsert();
			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@RegistroID=@RegistroID ",
			   new object[]
			   {
					new SqlParameter("Operacion", 19),
					new SqlParameter("Opcion", Opcion),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("RegistroID", RegistroID)
			   }).AsNoTracking().ToList();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{
				if (query.Any())
				{

					Json = JsonConvert.SerializeObject(query);
				}
			}
			else
			{
				Json = "Error";
			}

			return Ok(Json);
		}
	}
}
