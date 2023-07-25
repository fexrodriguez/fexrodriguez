using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord;
using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelChanges;

namespace FactoryPlatform.Areas.Quality.Controllers.Reports.ModelChanges
{
	[Area("Quality")]
	[ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
	public class R_ModelChanges : Controller
    {
		private LKQMXFPAPPContext _fpContext;
		private StoresProceduresDbContext _spContext;
		private readonly LUsers _lUsers;

		public R_ModelChanges(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
		{
			_fpContext = fpContext;
			_spContext = spContext;
			_lUsers = new LUsers(appContext);
			_spContext.Database.SetCommandTimeout(400);
		}



		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult SearchInfo(string DateRange)
		{
			var FechaInicio = DateRange != null ? DateRange.Split("-")[0].Trim().ToString() : "-";
			var FechaFin = DateRange != null ? DateRange.Split("-")[1].Trim() : "-";
			var UserInfo = _lUsers.getIdUser(User).First();
			var jsonDatos = "";
			var error = "";

			var query = new List<R_ModelChangesList>();

			try
			{
				query = _spContext.R_ModelChangesList.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
				"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @FechaInicio=@FechaInicio,  @FechaFin=@FechaFin",
				new object[]
				{
					new SqlParameter("Operacion", 21),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("FechaInicio", FechaInicio),
					new SqlParameter("FechaFin", FechaFin),
				}).AsNoTracking().ToList();

			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{

				jsonDatos = JsonConvert.SerializeObject(query);
			}
			else
			{
				jsonDatos = "Error";
			}

			return Ok(jsonDatos);
		}
	}
}
