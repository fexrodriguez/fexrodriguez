using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityFailsInProcess
    {
        public int IdRegistro { get; set; }
        public string Serie { get; set; }
        public int? FamiliaId { get; set; }
        public string Modelo { get; set; }
        public int? CausaId { get; set; }
        public int? ComponenteId { get; set; }
        public byte? PruebaId { get; set; }
        public int? ResponsableId { get; set; }
        public byte? Line { get; set; }
        public string DescripcionCausa { get; set; }
        public string Notas { get; set; }
        public int? UsuarioRegistroCausaId { get; set; }
        public DateTime? FechaRegistroCausa { get; set; }
        public int? DepartamentoCausaId { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public byte? PlantaId { get; set; }
    }
}
