using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ServicesNowWorkOrdersClass
    {
        public int IdClase { get; set; }
        public string Clase { get; set; }
        public int TabSectionId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
