using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ItsystemsHardwareReferences
    {
        public int IdReferencia { get; set; }
        public string DescripcionReferencia { get; set; }
        public DateTime RevisionAnterior { get; set; }
        public DateTime? RevisionSiguiente { get; set; }
        public int? Intervalo { get; set; }
        public int? ProveedorId { get; set; }
        public string Modelo { get; set; }
        public int FabricanteId { get; set; }
        public string NumeroSerie { get; set; }
        public string So { get; set; }
        public int TipoReferenciaId { get; set; }
        public int EstacionId { get; set; }
        public bool MantenimientoExterno { get; set; }
        public bool? DominioLkq { get; set; }
        public int? UsuarioAd { get; set; }
        public string NegocioCritico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? UsuarioActualizacionId { get; set; }
        public string Comentarios { get; set; }
        public int? PlantaId { get; set; }
        public int Status { get; set; }
    }
}
