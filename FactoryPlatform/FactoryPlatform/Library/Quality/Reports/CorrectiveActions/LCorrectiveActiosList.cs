using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FactoryPlatform.Library.Quality
{
    public class LCorrectiveActiosList : ListObjects
    {
        public LCorrectiveActiosList(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        //======================================== Corrective Actions ===============================================================
        public CorrectiveActionListViewModel CorrectiveActionCombos(int UserID, int PlantaID)
        {
            var model = new CorrectiveActionListViewModel();

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

            var Departments = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 3),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Departments.Any())
            {
                Departments.ForEach(item =>
                {
                    model.Production_Departments.Add(new SelectListItem
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

            var Activity = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 5),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Activity.Any())
            {
                Activity.ForEach(item =>
                {
                    model.Quality_CA_Activity.Add(new SelectListItem
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

            var Quality_Processes = _SpContext.SelectOptionsCA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
            "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso =@Caso",
            new object[]
            {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Caso", 7),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (Quality_Processes.Any())
            {
                Quality_Processes.ForEach(item =>
                {
                    model.Quality_Processes.Add(new SelectListItem
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
                CAListCombos.Where(S => S.Tipo.Equals(1)).ToList().ForEach(item =>
                {
                    model.Status.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Opcion.ToString()
                    });
                });
            }

            if (CAListCombos.Any())
            {
                CAListCombos.Where(S => S.Tipo.Equals(2)).ToList().ForEach(item =>
                {
                    model.Rangers.Add(new SelectListItem
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

            return model;
        }


    }
}
