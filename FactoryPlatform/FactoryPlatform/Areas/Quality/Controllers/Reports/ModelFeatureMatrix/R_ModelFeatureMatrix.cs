using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureMatrix;

namespace FactoryPlatform.Areas.Quality.Controllers.Reports.ModelFeatureMatrix
{
	[Area("Quality")]
	[ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
	public class R_ModelFeatureMatrix : Controller
	{
		private LKQMXFPAPPContext _fpContext;
		private StoresProceduresDbContext _spContext;
		private readonly LUsers _lUsers;

		public R_ModelFeatureMatrix(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
		{
			_fpContext = fpContext;
			_spContext = spContext;
			_lUsers = new LUsers(appContext);
			//_spContext.Database.SetCommandTimeout(400);
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult SearchInfo(string Modelo,int EstacionID)
		{
			var UserInfo = _lUsers.getIdUser(User).First();
			var jsonDatos = "";
			var error = "";

			var query = new List<R_ModelFeatureMatrixList>();

			try
			{
				query = _spContext.R_ModelFeatureMatrixList.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
				"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Modelo=@Modelo,  @EstacionID=@EstacionID",
				new object[]
				{
					new SqlParameter("Operacion", 22),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", Modelo = Modelo != null ? Modelo : "-"),
					new SqlParameter("EstacionID", EstacionID),
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
