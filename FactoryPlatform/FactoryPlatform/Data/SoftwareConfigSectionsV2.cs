using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigSectionsV2
    {
        public int IdSeccion { get; set; }
        public string Seccion { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int AplicacionId { get; set; }
        public string Icono { get; set; }
        public string Direccion { get; set; }
        public bool InMenu { get; set; }
        public bool Actualizado { get; set; }
        public string CarpetaSite { get; set; }
        public string Tipo { get; set; }
        public int? PlantaId { get; set; }
        public string NewDireccion { get; set; }
        public int? QualityWorkStationId { get; set; }
    }
}
