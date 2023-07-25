using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesRequisicionPersonalReturn
    {
        public int IdRegistro { get; set; }
        public int RequisicionId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string ComentarioReturn { get; set; }
        public byte NivelAnterior { get; set; }
        public byte Nivel { get; set; }
        public int UsuarioReturnId { get; set; }
        public bool? Status { get; set; }
    }
}
