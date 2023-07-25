using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesSurveysCategories
    {
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string IconMenu { get; set; }
        public int? EncuestaId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificaId { get; set; }
        public bool? Status { get; set; }
    }
}
