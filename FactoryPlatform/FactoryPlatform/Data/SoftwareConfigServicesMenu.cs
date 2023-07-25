using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigServicesMenu
    {
        public int IdMenuService { get; set; }
        public string MenuSeccion { get; set; }
        public byte Nivel { get; set; }
        public string Icono { get; set; }
        public string MenuIconos { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string FileSystem { get; set; }
        public bool? InMenu { get; set; }
        public string QueryTabla { get; set; }
        public string Colors { get; set; }
        public string FontColor { get; set; }
        public bool? Status { get; set; }
        public string ActionMethod { get; set; }
    }
}
