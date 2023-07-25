using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigAppsV2
    {
        public int IdAplicacion { get; set; }
        public string Aplicacion { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int DepartamentoId { get; set; }
        public string Direccion { get; set; }
        public string DireccionUrl { get; set; }
        public string Icono { get; set; }
        public bool? Actualizado { get; set; }
        public string CarpetaSite { get; set; }

        public virtual Departments Departamento { get; set; }
    }
}
