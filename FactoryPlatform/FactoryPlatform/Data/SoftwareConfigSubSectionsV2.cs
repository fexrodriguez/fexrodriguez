using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigSubSectionsV2
    {
        public int IdSubSeccion { get; set; }
        public string SubSeccion { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int SeccionId { get; set; }
        public string Icono { get; set; }
        public string Direccion { get; set; }
        public bool InMenu { get; set; }
        public bool Actualizado { get; set; }
        public string CarpetaSite { get; set; }
        public int? PlantaId { get; set; }
        public string NewDireccion { get; set; }
    }
}
