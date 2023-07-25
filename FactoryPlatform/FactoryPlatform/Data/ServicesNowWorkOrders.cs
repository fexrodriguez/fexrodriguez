using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ServicesNowWorkOrders
    {
        public int IdWorkOrder { get; set; }
        public int MaquinaId { get; set; }
        public int ClaseId { get; set; }
        public int EstacionId { get; set; }
        public int TipoSeccionId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int UsuarioSupervisorId { get; set; }
        public string ComentarioApertura { get; set; }
        public int? TipoTrabajoId { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public int ProveedorId { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public int? UsuarioAsignadoId { get; set; }
        public string ComentarioAsignacion { get; set; }
        public DateTime? FechaDownTime { get; set; }
        public DateTime? FechaEstimadaServicio { get; set; }
        public string HoraEstimadaServicio { get; set; }
        public DateTime? FechaRegistroServicio { get; set; }
        public int? UsuarioRegistroServicioId { get; set; }
        public string ComentarioServicio { get; set; }
        public double? TiempoDeParo { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? UsuarioCancelacionId { get; set; }
        public string ComentariosCancelacion { get; set; }
        public DateTime? FechaRegistroCierre { get; set; }
        public int? UsuarioRegistroCierreId { get; set; }
        public string ComentariosCierre { get; set; }
        public int Calificacion { get; set; }
        public int PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
