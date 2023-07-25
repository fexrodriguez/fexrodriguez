using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigMainMenu
    {
        public int IdMenuSeccion { get; set; }
        public string MenuSeccion { get; set; }
        public int Nivel { get; set; }
        public string Icono { get; set; }
        public string MenuIconos { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string FileSystem { get; set; }
        public string QueryTabla { get; set; }
        public bool? InMenu { get; set; }
        public string Color { get; set; }
        public string ColorActivo { get; set; }
        public bool? Status { get; set; }
        public bool? TemporalId { get; set; }
        public string ActionMethod { get; set; }
    }
}
