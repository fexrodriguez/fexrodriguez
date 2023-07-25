using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Filter;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Library.Quality.Reports.CorrectiveActions;
using FactoryPlatform.Library.Quality;
using FactoryPlatform.Library;
using FactoryPlatform.Areas.Quality.Models.CorrectiveActions;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart;

namespace FactoryPlatform.Areas.Quality.Controllers.Reports.CorrectiveActions
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class R_CorrectiveActionChartController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _spContext;
        private readonly LUsers _lUsers;

        public R_CorrectiveActionChartController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _spContext = spContext;
            _lUsers = new LUsers(appContext);
        }

        public class RetornarChart
        {
            public string? Descripcion { get; set; }
            public int? Cero { get; set; }
            public int? UnoSiete { get; set; }
            public int? MasSiete { get; set; }
            public int? none { get; set; }
        }

        public class RetornarCAChartJson
        {
            public List<RetornarChart> ChartsJson { get; set; } = new List<RetornarChart>();
            public List<ReportChart_CA>  ReportChartsJson { get; set; } = new List<ReportChart_CA>();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult ReportCorrectiveActionsChart(int FilterOption, int Status, string IdRanges, string IdManagements, 
        string IdTools, string IdSources, string DateRanges, string IdResponsibles,
        string IdActioncategory, int IdSeccion)
        {
            var FechaInicio = DateRanges != null ? DateRanges.Split("-")[0].Trim().ToString() : "-";
            var FechaFin = DateRanges != null ? DateRanges.Split("-")[1].Trim() : "-";
            var jsonDatos = "";
            var UserInf = _lUsers.getIdUser(User).First();

            var queryChart = new List<Chart_CA>();
            var queryReport = new List<ReportChart_CA>();
            
            var Modelo = new RetornarCAChartJson();
            
            var error = "";

            //Grafica
            try
            {
                queryChart = _spContext.Chart_CA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion = @Operacion, " +
                "@UsuarioID = @UsuarioID, " +
                "@PlantaID = @PlantaID, " +
                "@ActionStatus = @ActionStatus, " +
                "@HerramientaFiltro = @HerramientaFiltro, " +
                "@Fuentes = @Fuentes," +
                "@FechaInicio = @FechaInicio," +
                "@FechaFin = @FechaFin," +
                "@CategoriaAcciones = @CategoriaAcciones," +
                "@Gerencia = @Gerencia," +
                "@Responsable = @Responsable," +
                "@Rangos = @Rangos," +
                "@Opcion = @Opcion ",
                new object[]
                {
                    new SqlParameter("Operacion", 13),
                    new SqlParameter("Opcion", FilterOption),
                    new SqlParameter("UsuarioID", UserInf.Usuario),
                    new SqlParameter("PlantaID", UserInf.PlantaId),
                    new SqlParameter("ActionStatus", Status ),
                    new SqlParameter("HerramientaFiltro", IdTools = IdTools != null ? IdTools : "-" ),
                    new SqlParameter("Fuentes", IdSources = IdSources != null ? IdSources : "-" ),
                    new SqlParameter("FechaInicio", FechaInicio = FechaInicio != null ? FechaInicio : "-"),
                    new SqlParameter("FechaFin",  FechaFin = FechaFin != null ? FechaFin: "-"),
                    new SqlParameter("CategoriaAcciones", IdActioncategory = IdActioncategory != null ? IdActioncategory :  "-"),
                    new SqlParameter("Gerencia", IdManagements = IdManagements != null ? IdManagements : "-"),
                    new SqlParameter("Responsable", IdResponsibles != null ? IdResponsibles  : "-"),
                    new SqlParameter("Rangos", IdRanges = IdRanges != null ? IdRanges : "-")
                }).AsNoTracking().ToList();

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            //Reporte
            try
            {
                queryReport = _spContext.ReportChart_CA.FromSqlRaw("EXEC spFPAPP_CorrectiveActions " +
                "@Operacion = @Operacion, " +
                "@UsuarioID = @UsuarioID, " +
                "@PlantaID = @PlantaID, " +
                "@ActionStatus = @ActionStatus, " +
                "@HerramientaFiltro = @HerramientaFiltro, " +
                "@Fuentes = @Fuentes," +
                "@FechaInicio = @FechaInicio," +
                "@FechaFin = @FechaFin," +
                "@CategoriaAcciones = @CategoriaAcciones," +
                "@Gerencia = @Gerencia," +
                "@Responsable = @Responsable," +
                "@Rangos = @Rangos," +
                "@Opcion = @Opcion ",
                new object[]
                {
                    new SqlParameter("Operacion", 14),
                    new SqlParameter("Opcion", FilterOption),
                    new SqlParameter("UsuarioID", UserInf.Usuario),
                    new SqlParameter("PlantaID", UserInf.PlantaId),
                    new SqlParameter("ActionStatus", Status ),
                    new SqlParameter("HerramientaFiltro", IdTools = IdTools != null ? IdTools : "-" ),
                    new SqlParameter("Fuentes", IdSources = IdSources != null ? IdSources : "-" ),
                    new SqlParameter("FechaInicio", FechaInicio = FechaInicio != null ? FechaInicio : "-"),
                    new SqlParameter("FechaFin",  FechaFin = FechaFin != null ? FechaFin: "-"),
                    new SqlParameter("CategoriaAcciones", IdActioncategory = IdActioncategory != null ? IdActioncategory :  "-"),
                    new SqlParameter("Gerencia", IdManagements = IdManagements != null ? IdManagements : "-"),
                    new SqlParameter("Responsable", IdResponsibles != null ? IdResponsibles  : "-"),
                    new SqlParameter("Rangos", IdRanges = IdRanges != null ? IdRanges : "-")
                }).AsNoTracking().ToList();

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {

                if(queryChart.Any())
                {
                    foreach (var item in queryChart)
                    {
                        Modelo.ChartsJson.Add(new RetornarChart()
                        {
                            Descripcion = item.Descripcion,
                            Cero = item.Cero,
                            UnoSiete = item.UnoSiete,
                            MasSiete = item.MasSiete == 0 ? null : item.MasSiete,
                            none = 0
                        });

                    }
                }


                Modelo.ReportChartsJson = queryReport;

                jsonDatos = JsonConvert.SerializeObject(Modelo);
            }
            else
            {
                jsonDatos = "Error";
            }

            return Ok(jsonDatos);
        }




    }
}
