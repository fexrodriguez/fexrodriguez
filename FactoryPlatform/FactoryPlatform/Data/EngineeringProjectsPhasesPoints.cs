using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringProjectsPhasesPoints
    {
        public int IdPunto { get; set; }
        public string Punto { get; set; }
        public byte? Nivel { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int FaseId { get; set; }
        public byte Status { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
    }
}
