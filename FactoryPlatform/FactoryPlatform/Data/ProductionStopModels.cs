using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionStopModels
    {
        public int IdRegistro { get; set; }
        public string Modelo { get; set; }
        public string MensajeAlerta { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? UsuarioLiberacionId { get; set; }
        public int? PlantaId { get; set; }
    }
}
