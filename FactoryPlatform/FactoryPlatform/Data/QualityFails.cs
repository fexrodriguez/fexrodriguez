using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityFails
    {
        public int IdRegistro { get; set; }
        public string Serie { get; set; }
        public int? EfectoId { get; set; }
        public int? CausaId { get; set; }
        public int? ComponenteId { get; set; }
        public byte? PruebaId { get; set; }
        public int? ResponsableId { get; set; }
        public string DescripcionEfecto { get; set; }
        public string DescripcionCausa { get; set; }
        public string DescripcionConclusion { get; set; }
        public int? UsuarioRegistroEfectoId { get; set; }
        public int? UsuarioRegistroCausaId { get; set; }
        public int? UsuarioRegistroConclusionId { get; set; }
        public DateTime? FechaRegistroEfecto { get; set; }
        public DateTime? FechaRegistroCausa { get; set; }
        public DateTime? FechaRegistroConclusion { get; set; }
        public int? DepartamentoCausaId { get; set; }
        public string SerieComponente { get; set; }
        public byte? ConclusionId { get; set; }
        public string TiempoReparacion { get; set; }
        public int? PlantaId { get; set; }
    }
}
