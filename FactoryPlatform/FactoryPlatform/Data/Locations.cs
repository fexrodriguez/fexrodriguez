using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class Locations
    {
        public int IdUbicacion { get; set; }
        public string Descripcion { get; set; }
        public string Dirección { get; set; }
        public string Tipo { get; set; }
        public bool? Status { get; set; }
        public string Telefono { get; set; }
        public int EstadoId { get; set; }
        public int MunicipioId { get; set; }
    }
}
