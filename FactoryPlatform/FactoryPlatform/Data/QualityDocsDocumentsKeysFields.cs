using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsDocumentsKeysFields
    {
        public int IdCampo { get; set; }
        public string Descripcion { get; set; }
        public byte Longitud { get; set; }
        public string Tipo { get; set; }
        public string ValorDefault { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public bool? Status { get; set; }
        public int ClaveDocumentoId { get; set; }
        public byte Orden { get; set; }
    }
}
