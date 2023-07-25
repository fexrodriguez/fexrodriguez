using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using Syncfusion.EJ2.Diagrams;
using System.Diagnostics;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.EJ2.Navigations;
using Newtonsoft.Json;
using System.Collections.Generic;
using FactoryPlatform.Areas.Quality.Models.CorrectiveActions;
using FactoryPlatform.Filter;

namespace FactoryPlatform.Areas.Quality.Controllers
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CorrectiveActionListController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        public CorrectiveActionListController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult ReportCorrectiveActionsList(string IdKey, int Status, string IdRangers, string IdManagements,
        string IdTools, string IdSources, string IdDepartaments, string DateRanges, string IdResponsibles, string IdClosed,
        string IdCategorys, string IdProcess, int IdSeccion)
        {
            var FechaInicio = DateRanges != null ? DateRanges.Split("-")[0].Trim().ToString() : "-";
            var FechaFin = DateRanges != null ? DateRanges.Split("-")[1].Trim() : "-";
            var jsonDatos = "";

            var UserInf = _lUsers.getIdUser(User).First();

            var query = new List<Report_CorrectiveAction_List>();
            var error = "";

            try
            {
                query = _SpContext.Report_CorrectiveAction_List.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion = @Operacion, " +
                "@UsuarioID = @UsuarioID, " +
                "@PlantaID = @PlantaID, " +
                "@ActionStatus = @ActionStatus, " +
                "@HerramientaFiltro = @HerramientaFiltro, " +
                "@Fuentes = @Fuentes," +
                "@Departamento = @Departamento," +
                "@FechaInicio = @FechaInicio," +
                "@FechaFin = @FechaFin," +
                "@CategoriaAcciones = @CategoriaAcciones," +
                "@Procesos= @Procesos," +
                "@CerradoPor = @CerradoPor," +
                "@Gerencia = @Gerencia," +
                "@Responsable = @Responsable," +
                "@Rangos = @Rangos," +
                "@Key = @Key ",
                new object[]
                {
                    new SqlParameter("Operacion", 8),
                    new SqlParameter("UsuarioID", UserInf.Usuario),
                    new SqlParameter("PlantaID", UserInf.PlantaId),
                    new SqlParameter("ActionStatus", Status ),
                    new SqlParameter("HerramientaFiltro", IdTools = IdTools != null ? IdTools : "-" ),
                    new SqlParameter("Fuentes", IdSources = IdSources != null ? IdSources : "-" ),
                    new SqlParameter("Departamento", IdDepartaments = IdDepartaments != null ? IdDepartaments : "-"),
                    new SqlParameter("FechaInicio", FechaInicio = FechaInicio != null ? FechaInicio : "-"),
                    new SqlParameter("FechaFin",  FechaFin = FechaFin != null ? FechaFin: "-"),
                    new SqlParameter("CategoriaAcciones", IdCategorys = IdCategorys != null ? IdCategorys :  "-"),
                    new SqlParameter("Procesos", IdProcess = IdProcess != null ? IdProcess: "-"),
                    new SqlParameter("CerradoPor", IdClosed = IdClosed != null ? IdClosed: "-"),
                    new SqlParameter("Gerencia", IdManagements = IdManagements != null ? IdManagements : "-"),
                    new SqlParameter("Responsable", IdResponsibles != null ? IdResponsibles  : "-"),
                    new SqlParameter("Rangos", IdRangers = IdRangers != null ? IdRangers : "-"),
                    new SqlParameter("Key", IdKey = IdKey != null ? IdKey : "-")
                }).AsNoTracking().ToList();

            }catch(Exception ex)
            {
                error = ex.Message;
            }

            if(error == "")
            {
                jsonDatos = JsonConvert.SerializeObject(query);
            }
            else
            {
                jsonDatos = "Error";
            }

            return Ok(jsonDatos);
        }



    }
}
