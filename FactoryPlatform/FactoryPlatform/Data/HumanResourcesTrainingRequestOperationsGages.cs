using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingRequestOperationsGages
    {
        public int IdRegistro { get; set; }
        public int? SolicitudId { get; set; }
        public int? GageId { get; set; }
        public string Comentarios { get; set; }
        public string Resultado { get; set; }
        public bool? Actualizado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
