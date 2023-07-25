using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class Factories
    {
        public int IdPlanta { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public bool? Status { get; set; }
        public string Contacto { get; set; }
        public string CorreoContacto { get; set; }
        public string Direccion { get; set; }
        public string Site { get; set; }
        public string Locacion { get; set; }
    }
}
