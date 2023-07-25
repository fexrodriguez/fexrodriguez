using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceProcessPlanner
    {
        public int IdPlaneacion { get; set; }
        public int ProcesoId { get; set; }
        public DateTime? FechaMantenimiento { get; set; }
        public int? SemanaMantenimiento { get; set; }
        public DateTime? FechaPlaneado { get; set; }
        public int? UsuarioPlaneoId { get; set; }
        public int? UsuarioAsignadoId { get; set; }
        public DateTime? FechaRegistroServicio { get; set; }
        public int? UsuarioRegistroServicioId { get; set; }
        public bool Formato { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? Status { get; set; }
    }
}
