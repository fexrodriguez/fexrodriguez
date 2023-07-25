using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionModels
    {
        public int IdModelo { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int? FamiliaId { get; set; }
        public string Linea { get; set; }
        public int? ComponenteId { get; set; }
        public int? PruebaId { get; set; }
        public bool? Status { get; set; }
        public string VegeCode { get; set; }
        public int? PlantaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public int? UsuarioUltimaActualizacionId { get; set; }
        public int? EmbalajeId { get; set; }
        public int? HuacalId { get; set; }
        public int? TubinsertoId { get; set; }
        public int? TubinsertoMaderaId { get; set; }
        public int? TubtapaId { get; set; }
        public int? TubbaseId { get; set; }
        public bool? CargaSyteLine { get; set; }
    }
}
