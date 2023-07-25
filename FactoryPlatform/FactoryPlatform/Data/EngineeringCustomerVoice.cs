using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringCustomerVoice
    {
        public int IdRegistro { get; set; }
        public string Proyecto { get; set; }
        public string NumeroParte { get; set; }
        public DateTime Fecha { get; set; }
        public byte Tipo { get; set; }
        public byte Status { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Comments { get; set; }
        public string CustomerName { get; set; }
        public string CustomerOrg { get; set; }
        public int? ProyectoId { get; set; }
    }
}
