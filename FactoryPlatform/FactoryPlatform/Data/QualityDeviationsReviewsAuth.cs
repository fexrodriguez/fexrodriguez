using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviationsReviewsAuth
    {
        public int IdRegistro { get; set; }
        public int ReviewId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public string Comentario { get; set; }
        public bool? Status { get; set; }
        public byte? Nivel { get; set; }
    }
}
