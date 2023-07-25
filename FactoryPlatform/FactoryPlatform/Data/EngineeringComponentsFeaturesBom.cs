using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringComponentsFeaturesBom
    {
        public int IdCaracteristica { get; set; }
        public int ComponenteId { get; set; }
        public int CaracteristicaComponenteId { get; set; }
        public int Orden { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
