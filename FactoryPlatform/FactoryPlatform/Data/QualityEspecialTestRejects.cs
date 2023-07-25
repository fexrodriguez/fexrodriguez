using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityEspecialTestRejects
    {
        public int IdRegistro { get; set; }
        public int TestId { get; set; }
        public DateTime FechaRechazo { get; set; }
        public int UsuarioRechazoId { get; set; }
        public string Comentario { get; set; }
        public int Nivel { get; set; }
        public bool? Status { get; set; }
    }
}
