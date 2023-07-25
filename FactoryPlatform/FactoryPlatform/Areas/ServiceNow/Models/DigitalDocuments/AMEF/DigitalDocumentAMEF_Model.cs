using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models   
{
    public class DigitalDocumentAMEF_Model
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? Desarrollo { get; set; }
        public string? FechaRegistro { get; set; }
        public string? Registro { get; set; }
        public string? Asignado { get; set; }
        public string? QuestionsAMEF { get; set; }
        public string? Results { get; set; }
        public string? Coments { get; set; }
        public string? QualityDetermination { get; set; }
        public string? QualityComments { get; set; }
        public string? ReviewsUsers { get; set; }
    }
}


