using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureList;
using System.Linq;

namespace FactoryPlatform.Library.Quality.Reports.Models.ModelFeatureList
{
    public class LModelFeatureList : ListObjects
    {
        public LModelFeatureList(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        public R_ModelFeatureListViewModel GetModelFeatureView(int UserID, int PlantaID)
        {
            var error = "";
            var query = new R_ModelFeatureListViewModel();

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
                    new SqlParameter("Operacion", 15),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            return query;
        }


        public R_ModelFeatureListViewModel GetReport(int UserID, int PlantaID, int EstacionID)
        {
            var error = "";
            var query = new R_ModelFeatureListViewModel();

            query.R_ModelFeatureList = _SpContext.R_ModelFeatureList.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
            "@Opcion= @Opcion, @EstacionID=@EstacionID ",
            new object[]
            {
                    new SqlParameter("Operacion", 15),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("PlantaID", PlantaID),
                    new SqlParameter("EstacionID", EstacionID),
            }).AsNoTracking().ToList();

            return query;
        }


    }
}
