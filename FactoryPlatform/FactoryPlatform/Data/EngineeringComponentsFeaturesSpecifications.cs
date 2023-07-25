using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringComponentsFeaturesSpecifications
    {
        public int IdEspecificacion { get; set; }
        public int ComponenteId { get; set; }
        public int ModeloId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioBajaId { get; set; }
        public DateTime? FechaRegistroBaja { get; set; }
        public int? UsuarioLiberoId { get; set; }
        public DateTime? FechaLibero { get; set; }
        public int? UsuarioAprobacionId { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public int? UsuarioRechazoId { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public int Status { get; set; }
    }
}
