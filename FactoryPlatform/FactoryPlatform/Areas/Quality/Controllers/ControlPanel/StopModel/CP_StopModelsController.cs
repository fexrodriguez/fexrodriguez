using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Filter;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.UpdModelToSerie;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Models;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.StopModel
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CP_StopModelsController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LModels _lModels;

        public CP_StopModelsController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
            _lModels = new LModels(spContext);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult StopModel(string Modelo, string Alert, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
                "@Opcion= @Opcion, @StrAlerta=@StrAlerta," +
                "@Modelo=@Modelo ",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Modelo", Modelo== null ? "-" : Modelo),
                    new SqlParameter("StrAlerta", Alert== null ? "-" : Alert)
                }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = JsonConvert.SerializeObject(query);
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteStope(int RegisterID, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
                "@Opcion= @Opcion, @RegisterID=@RegisterID ",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Opcion", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("RegisterID", RegisterID)

                }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = query.First().Resultado;
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


    }
}
