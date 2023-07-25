using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsReviews
    {
        public int IdRegistro { get; set; }
        public int DocumentoId { get; set; }
        public int RevisionId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int SolicitanteId { get; set; }
        public int ResponsableId { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaTerminacion { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public string Revision { get; set; }
        public string Validacion { get; set; }
        public string TipoArchivo { get; set; }
        public string OrigenComentario { get; set; }
        public int? DigitalId { get; set; }
        public byte? TipoDigital { get; set; }
        public int? ProyectoId { get; set; }
    }
}
