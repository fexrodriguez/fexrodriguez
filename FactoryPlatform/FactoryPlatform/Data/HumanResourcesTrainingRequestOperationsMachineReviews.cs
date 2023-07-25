using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingRequestOperationsMachineReviews
    {
        public int IdRegistro { get; set; }
        public int? SolicitudId { get; set; }
        public string Maquina { get; set; }
        public string Revision { get; set; }
        public string Comentarios { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
