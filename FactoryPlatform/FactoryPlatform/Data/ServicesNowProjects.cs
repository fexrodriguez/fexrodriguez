using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ServicesNowProjects
    {
        public int IdProyecto { get; set; }
        public string DescripcionProyecto { get; set; }
        public int? PlannerId { get; set; }
        public int? DepartamentoId { get; set; }
        public int? OwnerId { get; set; }
        public string Icono { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioAsignadoId { get; set; }
        public string Comentarios { get; set; }
        public int? Nivel { get; set; }
        public bool? Status { get; set; }
    }
}
