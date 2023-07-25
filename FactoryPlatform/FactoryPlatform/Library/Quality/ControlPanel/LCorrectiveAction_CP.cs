using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Areas.Quality.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FactoryPlatform.Library
{
    public class LCorrectiveAction_CP : ListObjects
    {
        public LCorrectiveAction_CP(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        //======================================== Control Panel Corrective Actions ===============================================================
        public CorrectiveAction_CP_ModelView CorrectiveActionInf(int UserID, int PlantaID)
        {
            var model = new CorrectiveAction_CP_ModelView();


            model.CA_Responsible_CP = _SpContext.CA_Responsible_CP.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 11),
                new SqlParameter("Caso", 1),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            model.CA_ResponsiblesManagements_CP = _SpContext.CA_ResponsiblesManagements_CP.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 11),
                new SqlParameter("Caso", 2),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();


            var Management = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 11),
                new SqlParameter("Caso", 3),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Management.Any())
            {
                Management.ForEach(item =>
                {
                    model.Managements.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            model.CA_Responsible_Closers_CP = _SpContext.CA_Responsible_CP.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                 new SqlParameter("Operacion", 11),
                 new SqlParameter("Caso", 4),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            model.Quality_CA_Sources = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                 new SqlParameter("Operacion", 11),
                 new SqlParameter("Caso", 5),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();


            model.Quality_CA_TypeSolutions = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                 new SqlParameter("Operacion", 11),
                 new SqlParameter("Caso", 6),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            model.Quality_CA_Processes = _SpContext.Quality_Processes_CP.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                 new SqlParameter("Operacion", 11),
                 new SqlParameter("Caso", 7),
                 new SqlParameter("UsuarioID", UserID),
                 new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            return model;
        }


    }
}
