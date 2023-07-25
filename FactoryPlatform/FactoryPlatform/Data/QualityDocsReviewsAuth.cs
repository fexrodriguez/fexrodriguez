using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsReviewsAuth
    {
        public int IdRegistro { get; set; }
        public int RevisionId { get; set; }
        public int DocumentoId { get; set; }
        public int UsuarioId { get; set; }
        public byte Nivel { get; set; }
        public byte? Status { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
