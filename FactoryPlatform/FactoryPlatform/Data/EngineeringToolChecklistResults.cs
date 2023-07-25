using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringToolChecklistResults
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? ActividadId { get; set; }
        public int ChecklistId { get; set; }
        public int ResponsableId { get; set; }
        public bool? Status { get; set; }
        public bool Adicional { get; set; }
        public string Codigo { get; set; }
        public int? UbicacionId { get; set; }
        public DateTime? Fecha { get; set; }
        public byte? StatusOperacion { get; set; }
    }
}
