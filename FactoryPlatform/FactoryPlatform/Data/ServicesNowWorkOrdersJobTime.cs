using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ServicesNowWorkOrdersJobTime
    {
        public int IdTurnoProduccion { get; set; }
        public int? PlantaId { get; set; }
        public int? Dia { get; set; }
        public TimeSpan? Entrada { get; set; }
        public TimeSpan? Salida { get; set; }
        public bool? Trabaja { get; set; }
        public bool? Status { get; set; }
    }
}
