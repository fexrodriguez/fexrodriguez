using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class UsersValidationSession
    {
        public int ValIdValidacion { get; set; }
        public int? SessionId { get; set; }
        public string Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaReg { get; set; }
        public string SessionTipo { get; set; }
        public int TipoSesion { get; set; }
        public DateTime? FechaCierreSesion { get; set; }
        public bool? Status { get; set; }
        public string Idsesion { get; set; }
    }
}
