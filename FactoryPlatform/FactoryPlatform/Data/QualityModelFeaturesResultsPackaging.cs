using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityModelFeaturesResultsPackaging
    {
        public int IdRegistro { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int EmbalajeId { get; set; }
        public int? HuacalId { get; set; }
        public int? TubtapaId { get; set; }
        public int? TubinsertoId { get; set; }
        public int? TubinsertoMaderaId { get; set; }
        public int? TubbaseId { get; set; }
        public int? TubproblemaId { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
