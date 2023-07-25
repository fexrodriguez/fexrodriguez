using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelsSequencesList;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FactoryPlatform.Library.Quality.Reports.Models.ModelSecuencesList
{
    public class LModelSecuences : ListObjects
    {
        public LModelSecuences(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }
        public R_ModelsSequencesListViewModel GetReport(int UserID, int PlantaID)
        {
            var error = "";
            var query = new R_ModelsSequencesListViewModel();

            query.R_Secuence = _SpContext.R_Secuence.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                    new SqlParameter("Operacion", 16),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            return query;
        }



    }
}
