using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesEmployeesMedicalExams
    {
        public int IdRegistro { get; set; }
        public int ExamenId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaExamen { get; set; }
        public bool? EsApto { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}
