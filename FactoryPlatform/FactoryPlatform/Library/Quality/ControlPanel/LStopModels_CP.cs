using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FactoryPlatform.Library.Quality.ControlPanel
{
    public class LStopModels_CP : ListObjects
    {

        public LStopModels_CP(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        public CP_StopModelsView StopedsModels(int UserID, int PlantaID)
        {
            var model = new CP_StopModelsView();

            model.CP_Stopeds = _SpContext.CP_Stopeds.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 12),
                 new SqlParameter("Opcion", 1),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            return model;
        }


    }
}
