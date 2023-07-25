using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringProjectsDocuments
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Documento { get; set; }
        public int Responsable { get; set; }
        public bool Digital { get; set; }
        public byte Status { get; set; }
        public string Clave { get; set; }
        public int? PantallaId { get; set; }
        public int? DocumentoDigitalId { get; set; }
        public byte? Tipo { get; set; }
    }
}
