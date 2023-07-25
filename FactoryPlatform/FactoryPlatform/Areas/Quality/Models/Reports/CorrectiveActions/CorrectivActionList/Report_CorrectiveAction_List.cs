using FactoryPlatform.Data;
using Syncfusion.EJ2.Diagrams;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace FactoryPlatform.Areas.Quality.Models.CorrectiveActions
{
    public class Report_CorrectiveAction_List
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Clave   {get; set;}
        public string? Herramienta { get; set; }
        public string? Fuente { get; set; }
        public string? Departamento { get; set; }
        public string? CategoriaAccion { get; set; }
        public string? Gerencia { get; set; }
        public string? ResponsableSeguimiento { get; set; }
        public string? ResponsableActividad { get; set; }
        public DateTime? FechaApertura { get; set; }
        public DateTime? FechaPromesa { get; set; }
        public string? Causas { get; set; }
        public string? Acciones { get; set; }
        public string? Proceso { get; set; }
        public string? CerradoPor { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioRegistro { get; set; }
        public string? UsuarioDelete { get; set; }
        public DateTime? FechaRegistroDelete { get; set; }
        public string? ComentarioDelete { get; set; }



        //======================================================
        //public string? Solucion    {get; set;}
        //public string? RASPFamilia {get; set;}
        //public string? RASPFailureCode {get; set;}
        //public string? TipoArchivoEvidencia {get; set;}
        //public string? Dias_Vencidos {get; set;}
        //public string? Dias_x_Vencer{get; set;}

        //======================================================
        //No se utilizan 
        //public int? ProcesoID   {get; set;}
        //public string? Solucion {get; set;}
        //public string? RASPFamilia {get; set;}
        //public string? RASPFailureCode {get; set;}
        //public string? TipoArchivoEvidencia {get; set;}
    }
}
