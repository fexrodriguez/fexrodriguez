using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceProcessHistoryNextService
    {
        public int IdRegistro { get; set; }
        public int ProcesoId { get; set; }
        public DateTime FechaProximoMantenimientoAnterior { get; set; }
        public DateTime FechaProximoMantenimientoNueva { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Comentarios { get; set; }
        public bool? Status { get; set; }
    }
}
