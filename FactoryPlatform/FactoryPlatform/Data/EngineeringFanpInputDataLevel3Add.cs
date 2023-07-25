using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringFanpInputDataLevel3Add
    {
        public int IdRegistro { get; set; }
        public int? RegistroEntradaId { get; set; }
        public int? SolicitudId { get; set; }
        public int? Fanp { get; set; }
        public string Caracteristica { get; set; }
        public string Unidad { get; set; }
        public string Minimo { get; set; }
        public string Maximo { get; set; }
        public string Medicion { get; set; }
        public string Conclusion { get; set; }
        public bool? Modificado { get; set; }
        public bool? Status { get; set; }
    }
}
