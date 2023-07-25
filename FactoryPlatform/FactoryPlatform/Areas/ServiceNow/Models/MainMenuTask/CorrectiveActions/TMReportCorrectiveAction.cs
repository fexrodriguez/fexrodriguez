using Syncfusion.EJ2.Diagrams;
using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.PendingTask.CorrectiveActions
{
    public class TMReportCorrectiveAction
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Clave   {get; set;}
        public string? Acciones {get; set;}
        public string? FechaApertura   {get; set;}
        public string? FechaPromesa {get; set;}
        public int? Nivel   {get; set;}
        public string? Comentarios {get; set;}
        public string? ResponsableSeguimiento  {get; set;}
        public string? ResponsableActividad {get; set;}
        public string? Responsable {get; set;}
        public int? Tipo {get; set;}
        public string? Retorno{get; set;}
        public string? IconoRev { get; set; }
        public  int? CloseBit { get; set; }
        public byte? Privilegio { get; set; }

    }
}
