using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library.Quality.ControlPanel;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Filter;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.UpdModelToSerie;
using FactoryPlatform.Models;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.UpdModelToSerie
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CP_UpdModelToSerieController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LModels _lModels;

        public CP_UpdModelToSerieController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
            _lModels = new LModels(spContext);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SerieSearch(string Serie, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<CP_SerieSearch>();

            try
            {
               query = _SpContext.CP_SerieSearch.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@Opcion= @Opcion, @Serie=@Serie ",
               new object[]
               {
                    new SqlParameter("Operacion", 10),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Serie", Serie == null ? "-" : Serie),
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
        public IActionResult NewModel (string Serie, string Modelo, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
                "@Opcion= @Opcion, @Serie=@Serie, @Modelo=@Modelo ",
                new object[]
                {
                    new SqlParameter("Operacion", 10),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Serie", Serie == null ? "-" : Serie),
                    new SqlParameter("Modelo", Modelo == null ? "-" : Modelo)
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
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }



    }
}
