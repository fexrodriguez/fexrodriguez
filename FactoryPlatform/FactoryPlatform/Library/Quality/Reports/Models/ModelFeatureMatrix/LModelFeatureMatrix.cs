using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureMatrix;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureMatrix
{
    public class LModelFeatureMatrix : ListObjects
    {
		public LModelFeatureMatrix(StoresProceduresDbContext spContext)
		{
			_SpContext = spContext;
		}

		public R_ModelFeatureMatrixViewModel GetModelMatrix(int UserID, int PlantaID)
		{
			var error = "";
			var query = new R_ModelFeatureMatrixViewModel();

			query.WorkStation = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			"@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
			"@Opcion= @Opcion ",
			new object[]
			{
					new SqlParameter("Operacion", 1),
					new SqlParameter("Opcion", 14),
					new SqlParameter("UsuarioID", UserID),
					new SqlParameter("PlantaID", PlantaID),
			}).AsNoTracking().ToList();

			return query;
		}
	}
}
