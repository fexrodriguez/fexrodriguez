
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureRecord
{
	public class LModelFeaturesRecord : ListObjects
	{
		public LModelFeaturesRecord(StoresProceduresDbContext spContext)
		{
			_SpContext = spContext;
		}

		public R_ModelFeatureRecordListViewModel GetModelFeature(int UserID, int PlantaID)
		{
			var error = "";
			var query = new R_ModelFeatureRecordListViewModel();

			query.WorkStation = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
			"@Opcion= @Opcion ",
			new object[]
			{
					new SqlParameter("Operacion", 1),
					new SqlParameter("Opcion", 12),
					new SqlParameter("UsuarioID", UserID),
					new SqlParameter("PlantaID", PlantaID),
			}).AsNoTracking().ToList();

			query.Employees = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
			"@Opcion= @Opcion ",
			new object[]
			{
					new SqlParameter("Operacion", 1),
					new SqlParameter("Opcion", 13),
					new SqlParameter("UsuarioID", UserID),
					new SqlParameter("PlantaID", PlantaID),
			}).AsNoTracking().ToList();

			return query;
		}


	}
}
