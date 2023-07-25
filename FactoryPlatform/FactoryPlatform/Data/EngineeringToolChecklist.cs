using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringToolChecklist
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Codigo { get; set; }
        public int ComponenteId { get; set; }
        public int TemplateId { get; set; }
        public bool? Status { get; set; }
        public int? ProyectoId { get; set; }
    }
}
