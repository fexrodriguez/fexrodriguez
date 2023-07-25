using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static FactoryPlatform.Areas.Quality.Controllers.ControlPanel.Models.CP_ModelsController;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelSequences;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.ModelSequences
{
	[Area("Quality")]
	[ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
	public class CP_ModelSequencesController : Controller
    {
		private LKQMXFPAPPContext _fpContext;
		private StoresProceduresDbContext _SpContext;
		private readonly LUsers _lUsers;
		private readonly LModels _lModels;

		public CP_ModelSequencesController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
		{
			_fpContext = fpContext;
			_SpContext = spContext;
			_lUsers = new LUsers(appContext);
			_lModels = new LModels(spContext);
		}

        //Buscar informacion 
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult SearchInfo(string Modelo)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";
			//var model = new ReturnInsert();
			var query = new List<CP_MSequencesModel>();

			try
			{
				query = _SpContext.CP_MSequencesModel.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@Modelo = @Modelo ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 1),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", Modelo)
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

		//Guardar Sequences 
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult SaveSequences(string Sequences, string Modelo)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Json = "";
			var error = "";

			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@Modelo=@Modelo,@Pruebas=@Pruebas ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 2),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Pruebas", Sequences),
					new SqlParameter("Modelo", Modelo)
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

		//Validar Modelo 
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult validateModel(string Modelo)
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
			   "@Modelo=@Modelo ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 5),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", Modelo)
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

		//Ordenar las Secuencias 
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult orderSequences(string orderData, string orderDataModel)
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
			   "@Modelo=@Modelo,@Pruebas=@Pruebas ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 3),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Pruebas", orderData),
					new SqlParameter("Modelo", orderDataModel)
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


		//Borrar una Secuencia 
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult DeleteSequence(int SequenceID, int Sequence,string Modelo)
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
			   "@Modelo=@Modelo,@PruebaID=@PruebaID,@Secuencia=@Secuencia ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 4),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("PruebaID", SequenceID),
					new SqlParameter("Secuencia", Sequence),
					new SqlParameter("Modelo", Modelo)
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

        //Copiar las secuencias de un modelo a otro
		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult CopyModel(string ModeloAnterior, string ModeloNuevo)
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
			   "@Modelo=@Modelo, @NewModelo=@NewModelo ",
			   new object[]
			   {
					new SqlParameter("Operacion", 11),
					new SqlParameter("Opcion", 6),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", ModeloAnterior),
					new SqlParameter("NewModelo", ModeloNuevo)
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
