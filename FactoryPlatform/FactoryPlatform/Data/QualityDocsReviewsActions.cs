using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsReviewsActions
    {
        public int IdRegistro { get; set; }
        public int RevisionId { get; set; }
        public int DocumentoId { get; set; }
        public int UsuarioId { get; set; }
        public byte Operacion { get; set; }
        public string Tipo { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
