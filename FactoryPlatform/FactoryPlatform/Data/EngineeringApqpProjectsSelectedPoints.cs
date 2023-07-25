using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringApqpProjectsSelectedPoints
    {
        public int IdRegistro { get; set; }
        public int ProyectoId { get; set; }
        public int PuntoId { get; set; }
        public int? ResponsableId { get; set; }
        public DateTime? FechaPuntoPlan { get; set; }
        public DateTime? FechaRevisionPlan { get; set; }
        public DateTime? FechaPuntoReal { get; set; }
        public DateTime? FechaRevisionReal { get; set; }
        public string ComentariosNoSelected { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaTerminado { get; set; }
        public int? UsuarioTerminadoId { get; set; }
        public byte Status { get; set; }
    }
}
