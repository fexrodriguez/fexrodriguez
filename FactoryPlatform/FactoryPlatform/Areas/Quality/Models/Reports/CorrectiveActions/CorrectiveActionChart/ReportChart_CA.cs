using System.ComponentModel.DataAnnotations;
using System;
using FactoryPlatform.Data;
using Syncfusion.EJ2.Diagrams;

namespace FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart
{
    public class ReportChart_CA
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Tiempo { get; set; }
        public string? Clave { get; set; }
        public string? Herramienta { get; set; }
        public string? Fuente { get; set; }
        public string? Departamento { get; set; }
        public string? CategoriaAccion { get; set; }
        public string? ResponsableSeguimiento { get; set; }
        public string? ResponsableActividad { get; set; }
        public DateTime? FechaApertura { get; set; }
        public DateTime? FechaPromesa { get; set; }
        public string? Causas { get; set; }
        public string? Acciones { get; set; }
        public string? CerradoPor { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioRegistro { get; set; }


        public string? Solucion { get; set; }
        public string? RASPFamilia { get; set; }
        public string? RASPFailureCode { get; set; }
        public string? TipoArchivoEvidencia { get; set; }


        public string? Analisis { get; set; }
        public string? Evidencia { get; set; }

    }
}
