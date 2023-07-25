using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringOpenIssuesList
    {
        public int IdRegistro { get; set; }
        public int IssueId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Hallazgo { get; set; }
        public DateTime FechaDeteccion { get; set; }
        public byte SeveridadId { get; set; }
        public string Descripcion { get; set; }
        public int ResponsableId { get; set; }
        public byte Tipo { get; set; }
        public int DepartamentoId { get; set; }
        public string Accion { get; set; }
        public DateTime FechaCierre { get; set; }
        public int Status { get; set; }
        public string AccionCorrectiva { get; set; }
        public int? AdpId { get; set; }
        public string AdpDescription { get; set; }
    }
}
