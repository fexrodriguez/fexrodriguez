using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesSurveysCuestions
    {
        public int IdPregunta { get; set; }
        public string DescripcionPregunta { get; set; }
        public int? OrdenId { get; set; }
        public int? DimensionId { get; set; }
        public int? DominioId { get; set; }
        public int? CategoriaId { get; set; }
        public int? Valor1 { get; set; }
        public int? Valor2 { get; set; }
        public int? Valor3 { get; set; }
        public int? Valor4 { get; set; }
        public int? Valor5 { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}
