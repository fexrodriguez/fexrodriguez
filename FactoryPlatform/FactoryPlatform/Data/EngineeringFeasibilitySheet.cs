using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringFeasibilitySheet
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Proyecto { get; set; }
        public int? Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public byte Conclusion { get; set; }
        public string Comments { get; set; }
        public byte Status { get; set; }
        public int? ProyectoId { get; set; }
    }
}
