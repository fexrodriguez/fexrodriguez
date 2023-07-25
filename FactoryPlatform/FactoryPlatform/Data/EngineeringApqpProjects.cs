using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringApqpProjects
    {
        public int IdProyecto { get; set; }
        public string Motor { get; set; }
        public string NumeroProyecto { get; set; }
        public DateTime FechaProyecto { get; set; }
        public int ResponsableId { get; set; }
        public byte Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
