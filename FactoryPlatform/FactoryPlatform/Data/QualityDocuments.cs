using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocuments
    {
        public int IdDocumento { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public byte Status { get; set; }
        public int TipoDocumentoId { get; set; }
        public int? UsuarioRegistroBajaId { get; set; }
        public string ComentariosBaja { get; set; }
        public bool Confidencial { get; set; }
        public bool? Formato { get; set; }
        public int? PlantaId { get; set; }
        public int? SolicitudAnp { get; set; }
        public int? ProcesoId { get; set; }
        public int? JobPositionId { get; set; }
        public int? TiempoRetencion { get; set; }
        public int? UsuarioSaveId { get; set; }
    }
}
