using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class spFPAPP_Sys_serviceNowValidation
    {
        [Key]
        public int ID { get; set; }
        public int Respuesta { get; set; }
        public string? Tipo { get; set; }
    }
}
