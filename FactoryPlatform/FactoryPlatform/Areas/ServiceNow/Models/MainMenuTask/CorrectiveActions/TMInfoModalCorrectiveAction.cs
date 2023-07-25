//using FactoryPlatform.Areas.ServiceNow.Models.PendingTask.CorrectiveActions;
//using FactoryPlatform.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.CorrectiveActions
{
    public class TMInfoModalCorrectiveAction 
    {
        [Key]
        public int? ID_Registro { get; set; }
        [DataType(DataType.Text)]
        public string? Clave   {get; set;}
        [DataType(DataType.Text)]
        public string? Tool {get; set;}
        [DataType(DataType.Text)]
        public string? Sources {get; set;}
        [DataType(DataType.Text)]
        public string? Departament {get; set;}
        [DataType(DataType.Text)]
        public string? Proceso {get; set;}
        [DataType(DataType.Text)]
        public string? ResponsableSeguimiento {get; set;}
        [DataType(DataType.Text)]
        public string? ResponsableActividad    {get; set;}
        [DataType(DataType.Text)]
        public string? Responsable {get; set;}
        [DataType(DataType.Text)]
        public string? FechaApertura   {get; set;}
        [DataType(DataType.Text)]
        public string? FechaPromesa {get; set;}
        [DataType(DataType.Text)]
        public string? Comentarios {get; set;}
        [DataType(DataType.Text)]
        public string? Causas {get; set;}
        [DataType(DataType.Text)]
        public string? Acciones    {get; set;}
        public int? Nivel {get; set;}
        [DataType(DataType.Text)]
        public string? BtnAnalys { get; set; }
        [DataType(DataType.Text)]
        public string? BtnEvidence { get; set; }
        [DataType(DataType.Text)]
        public string? CategoriaAccion { get; set; }
    }
}
