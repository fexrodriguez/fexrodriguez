using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringCustomerVoiceResults
    {
        public int IdRegistro { get; set; }
        public int QuestionId { get; set; }
        public int CustomerId { get; set; }
        public bool Producto { get; set; }
        public bool Proceso { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
