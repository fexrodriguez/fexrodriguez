using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigPagesDetails
    {
        public int IdPagina { get; set; }
        public string Direccion { get; set; }
        public string Titulo { get; set; }
        public int? PadreId { get; set; }
        public string Tipo { get; set; }
        public int? SubSeccionId { get; set; }
        public int? SeccionId { get; set; }
        public int? AplicacionId { get; set; }
        public bool? Actualizado { get; set; }
        public bool? InMenu { get; set; }
    }
}
