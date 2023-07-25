using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringOpenIssuesRejects
    {
        public int IdRegistro { get; set; }
        public int IssueId { get; set; }
        public int UsuarioRechazoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Comentario { get; set; }
        public int Nivel { get; set; }
    }
}
