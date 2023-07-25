using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringProjectsDocumentsReviews
    {
        public int IdRegistro { get; set; }
        public int DocumentoId { get; set; }
        public int ProyectoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public DateTime? FechaLiberado { get; set; }
        public bool? Status { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public string Comentario { get; set; }
    }
}
