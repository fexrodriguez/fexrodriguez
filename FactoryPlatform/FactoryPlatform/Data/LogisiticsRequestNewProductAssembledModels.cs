using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsRequestNewProductAssembledModels
    {
        public int IdRegistro { get; set; }
        public int? RequestId { get; set; }
        public int ProveedorId { get; set; }
        public int ArticuloId { get; set; }
        public int ModeloId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}
