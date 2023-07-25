using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringProjects
    {
        public int IdRegistro { get; set; }
        public string Projecto { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IngenieroAsignadoId { get; set; }
        public string Descripcion { get; set; }
        public byte Status { get; set; }
        public int? TipoId { get; set; }
        public int? ComponenteId { get; set; }
        public int? UsuarioCierreId { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string ComentarioCierre { get; set; }
        public int? Avance { get; set; }
    }
}
