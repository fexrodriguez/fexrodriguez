using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FactoryPlatform.Library.Quality.Reports.CorrectiveActions
{
    public class LCorrectiveActionsChart : ListObjects
    {
        public LCorrectiveActionsChart(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        public CorrectiveActionChartViewModel CorrectiveActionCombos(int UserID, int PlantaID)
        {
            var model = new CorrectiveActionChartViewModel();

            //Step 1 combos
            var Tools = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 1),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Tools.Any())
            {
                Tools.ForEach(item =>
                {
                    model.Quality_CA_Tools.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Responsible = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
           "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 4),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (Responsible.Any())
            {
                Responsible.ForEach(item =>
                {
                    model.Quality_CA_Responsible.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var Sources = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 2),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Sources.Any())
            {
                Sources.ForEach(item =>
                {
                    model.Quality_CA_Sources.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }



            //Step 3 combos
            var Closer = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
               new object[]
               {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 8),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
               }).AsNoTracking().ToList();

            if (Closer.Any())
            {
                Closer.ForEach(item =>
                {
                    model.ClosersUsers.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }

            var CAListCombos = _SpContext.CA_List_Combos.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
             "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
             new object[]
             {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 10),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
             }).AsNoTracking().ToList();

            if (CAListCombos.Any())
            {
                
                CAListCombos.Where(S => S.Tipo.Equals(3)).ToList().ForEach(item =>
                {
                    model.FilterOptions.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Opcion.ToString()
                    });
                });
            

                CAListCombos.Where(S => S.Tipo.Equals(4)).ToList().ForEach(item =>
                {
                    model.Rangers.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Opcion.ToString()
                    });
                });

                CAListCombos.Where(S => S.Tipo.Equals(5)).ToList().ForEach(item =>
                {
                    model.Status.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Opcion.ToString()
                    });
                });
            }

            var Management = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 11),
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

            var CategoryAccion = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
          "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
          new object[]
          {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 6),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
          }).AsNoTracking().ToList();

            if (CategoryAccion.Any())
            {
                CategoryAccion.ForEach(item =>
                {
                    model.Quality_CA_CategoryAccion.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Text.ToString()
                    });
                });
            }



            return model;
        }


    }
}
