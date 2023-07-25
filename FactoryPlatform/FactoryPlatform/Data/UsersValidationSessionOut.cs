using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class UsersValidationSessionOut
    {
        public int RegistroValidationId { get; set; }
        public int? SessionId { get; set; }
        public string Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FechaReg { get; set; }
        public string IpAddress { get; set; }
        public string SessionTipo { get; set; }
        public bool? Status { get; set; }
    }
}
