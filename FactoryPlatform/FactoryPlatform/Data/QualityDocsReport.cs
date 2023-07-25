using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsReport
    {
        public int IdRegistro { get; set; }
        public int? IdDocumento { get; set; }
        public int? RevisionId { get; set; }
        public string TipoArchivo { get; set; }
        public string StatusDocTxt { get; set; }
        public int? StatusDoc { get; set; }
        public string Clave { get; set; }
        public string DescDoc { get; set; }
        public string DescDoc2 { get; set; }
        public string Comentario { get; set; }
        public string FechaRegistroDoc { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public string UsuarioRegistro { get; set; }
        public string ClaveDt { get; set; }
        public string DescDt { get; set; }
        public string DateRevision { get; set; }
        public string ChangeDescription { get; set; }
        public int? CantidadAperturas { get; set; }
        public string ResponsableChange { get; set; }
        public string Solicitante { get; set; }
        public int? Rn { get; set; }
    }
}
