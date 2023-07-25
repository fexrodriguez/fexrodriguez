﻿using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsANP
    {
        [Key]
        public int? ID_Registro { get; set; }
        public string? Descripcion { get; set; }
        public string? Resultado { get; set; }
        public string? Unidad { get; set; }
        public string? Tipo { get; set; }
        public string? Minimo { get; set; }
        public string? Maximo { get; set; }
        public string? Medicion { get; set; }
        public string? Conclusion { get; set; } 
        public string? Color { get; set; }
        public bool? Status { get; set; }
        public int? Orden { get; set; }
        public int? TipoID { get; set; }
        public string? Title { get; set; }
    }
}