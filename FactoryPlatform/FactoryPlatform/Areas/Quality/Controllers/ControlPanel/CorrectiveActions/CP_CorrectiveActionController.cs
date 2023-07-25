using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FactoryPlatform.Models;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.ServiceNow.Models.ServiceMenu.CorrectiveAction;
using System.Collections.Generic;
using FactoryPlatform.Filter;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CP_CorrectiveActionController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;

        public CP_CorrectiveActionController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
        }


        //================================================ Responsibles =====================================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveResposibles(string Responsibles, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @Responsable=@Responsable",
               new object[]
               {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 1),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Responsable", Responsibles)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            result = error == "" ? "Success" : "Error";
            
            return Ok(result);
        }

        //=========================================================== Responsibles by Management
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveResponseByManager(int IdManager, int Usuario, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";

            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
               query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @GerenciaID=@GerenciaID",
               new object[]
               {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 2),
                    new SqlParameter("UsuarioID", Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("GerenciaID", IdManager)
               }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }

            result = error == "" ? "Success" : "Error";

            return Ok(result);
        }

        //========================================= Closed By
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveClosers(string Closers, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error ="";
            
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @Responsable=@Responsable",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Responsable", Closers)
                }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }

            result = error == "" ? "Success" : "Error";

            return Ok(result);
        }

        //============================================ Sources

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AddNewSources(string Source, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
               query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
              "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @Fuentes = @Fuentes ",
              new object[]
              {
                new SqlParameter("Operacion", 12),
                new SqlParameter("Caso", 4),
                new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                new SqlParameter("PlantaID", UserInfo.PlantaId),
                new SqlParameter("Fuentes", Source),
              }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }

            if(error == "")
            {
                if (query.Any())
                {
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                result = "Error";
            }

            return Ok(result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteSources(int IdSources, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso = @Caso, @FuenteID = @FuenteID",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 5),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("FuenteID", IdSources),
                }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Error";
                }
            }
            else
            {
                result = "Error";
            }

            return Ok(result);
        }

        //==================================================== Solution Types

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AddNewSolution(string Solution, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query  = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @Soluciones = @Soluciones",
               new object[]
               {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 6),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Soluciones", Solution),
               }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            

            if(error == "")
            {
                if (query.Any())
                {
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                result = "Error";
            }
            

            return Ok(result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteSolutionType(int IdSolution, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso = @Caso, @SolutionID = @SolutionID",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 7),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("SolutionID", IdSolution),
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
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Error";
                }
            }
            else
            {
                result = "Error";
            }


            return Ok(result);
        }

        //==================================================== Solution Types

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AddNewProccess(string Number, string Description, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, @Numero=@Numero, @Descripcion=@Descripcion",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 8),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("Numero", Number),
                    new SqlParameter("Descripcion", Description),
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
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                result = "Error";
            }

            return Ok(result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteProccess(int IdProccess, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try 
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso = @Caso, @ProcesoID= @ProcesoID",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 9),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("ProcesoID", IdProccess),
                }).AsNoTracking().ToList();
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Error";
                }
            }
            else
            {
                result = "Error";
            }

            return Ok(result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateProccess(int ProccessId, string Numero, string Description, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();
            var result = "";
            var error = "";

            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID,  @Caso=@Caso, " +
                "@Numero=@Numero, @Descripcion=@Descripcion, @ProcesoID=@ProcesoID ",
                new object[]
                {
                    new SqlParameter("Operacion", 12),
                    new SqlParameter("Caso", 10),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("ProcesoID", ProccessId),
                    new SqlParameter("Numero", Numero),
                    new SqlParameter("Descripcion", Description),
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
                    result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                result = "Error";
            }

            return Ok(result);
        }


    }

}
