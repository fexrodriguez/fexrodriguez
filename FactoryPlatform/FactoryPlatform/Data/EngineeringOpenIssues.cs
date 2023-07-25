using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringOpenIssues
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int ProyectoId { get; set; }
        public string NumeroParte { get; set; }
        public string JobOrder { get; set; }
        public int? Status { get; set; }
        public bool? AplicaId { get; set; }
    }
}
