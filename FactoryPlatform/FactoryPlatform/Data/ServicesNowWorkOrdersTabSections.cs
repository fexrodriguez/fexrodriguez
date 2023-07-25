using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ServicesNowWorkOrdersTabSections
    {
        public int IdSeccion { get; set; }
        public string Seccion { get; set; }
        public string Icono { get; set; }
        public string Onclick { get; set; }
        public string Tab { get; set; }
        public int? MenuId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
