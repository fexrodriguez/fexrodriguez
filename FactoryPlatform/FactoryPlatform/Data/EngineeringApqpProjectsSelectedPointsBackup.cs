using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringApqpProjectsSelectedPointsBackup
    {
        public int IdRegistro { get; set; }
        public int? RegistroId { get; set; }
        public int? ProyectoId { get; set; }
        public int? PuntoId { get; set; }
        public int? ResponsableId { get; set; }
        public DateTime? FechaPunto { get; set; }
        public DateTime? FechaRevision { get; set; }
        public string ComentariosNoSelected { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaTerminado { get; set; }
        public int? UsuarioTerminadoId { get; set; }
        public byte? Status { get; set; }
    }
}
