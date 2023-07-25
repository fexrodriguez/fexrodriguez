using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceServices
    {
        public int IdServicio { get; set; }
        public int MaquinaId { get; set; }
        public int ProcesoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public bool? Critico { get; set; }
        public bool Evidencia { get; set; }
        public string Comentarios { get; set; }
        public bool Formato { get; set; }
        public bool? Status { get; set; }
    }
}
