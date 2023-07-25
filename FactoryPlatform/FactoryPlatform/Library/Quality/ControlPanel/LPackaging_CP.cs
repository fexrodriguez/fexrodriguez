using FactoryPlatform.Areas.Quality.Models.ControlPanel.Packaging;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.StopModel;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FactoryPlatform.Library.Quality.ControlPanel
{
    public class LPackaging_CP : ListObjects
    {
        public LPackaging_CP(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        public CP_PackagindModelView GetPacking(int UserID, int PlantaID)
        {
            var model = new CP_PackagindModelView();

            model.Hucales = _SpContext.PackagingLists.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 1),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            model.TUB_PlasticInsert = _SpContext.PackagingLists.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 2),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            model.TUB_WoodInsert = _SpContext.PackagingLists.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 3),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();


            model.TUB_Lid = _SpContext.PackagingLists.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 4),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();


            model.CP_TubBase = _SpContext.CP_TubBase.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 5),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();


            model.Problem = _SpContext.PackagingLists.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion=@Opcion, " +
            "@UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                 new SqlParameter("Operacion", 13),
                 new SqlParameter("Opcion", 6),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();



            return model;
        }


    }
}
