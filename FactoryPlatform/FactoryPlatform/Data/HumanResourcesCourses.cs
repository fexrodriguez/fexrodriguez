using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesCourses
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int ProveedorId { get; set; }
        public byte CategoriaId { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public bool? Status { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioBajaId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string TipoCurso { get; set; }
    }
}
