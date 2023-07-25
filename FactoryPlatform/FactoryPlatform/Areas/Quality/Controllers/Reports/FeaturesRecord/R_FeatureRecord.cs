using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using static FactoryPlatform.Areas.Quality.Controllers.Reports.CorrectiveActions.R_CorrectiveActionChartController;
using FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord;
using Newtonsoft.Json;

namespace FactoryPlatform.Areas.Quality.Controllers.Reports.FeaturesRecord
{
	[Area("Quality")]
	[ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
	public class R_FeatureRecord : Controller
    {

		private LKQMXFPAPPContext _fpContext;
		private StoresProceduresDbContext _spContext;
		private readonly LUsers _lUsers;

		public R_FeatureRecord(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
		{
			_fpContext = fpContext;
			_spContext = spContext;
			_lUsers = new LUsers(appContext);
			_spContext.Database.SetCommandTimeout(400);
		}



		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult SearchInfo(string Model, string Serie, int Workstation, int Personal, string DateRange)
		{
			var FechaInicio = DateRange != null ? DateRange.Split("-")[0].Trim().ToString() : "-";
			var FechaFin = DateRange != null ? DateRange.Split("-")[1].Trim() : "-";
			var UserInfo = _lUsers.getIdUser(User).First();
			var jsonDatos = "";
			var error = "";

			var query = new List<R_ModelRecordFeatureList>();

			try
			{
				query = _spContext.R_ModelRecordFeatureList.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
				"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Modelo=@Modelo, @Serie=@Serie, " +
				"@EstacionID=@EstacionID, @Employee=@Employee, @FechaInicio=@FechaInicio,  @FechaFin=@FechaFin",
				new object[]
				{
					new SqlParameter("Operacion", 20),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", Model = Model != null ? Model : "-" ),
					new SqlParameter("Serie", Serie = Serie != null ? Serie : "-" ),
					new SqlParameter("EstacionID", Workstation),
					new SqlParameter("Employee", Personal),
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
