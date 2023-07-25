using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsEmployeesTrainingUpdatedDocs
    {
        public int IdRegistro { get; set; }
        public int DocumentoId { get; set; }
        public int? Revision { get; set; }
        public int UsuarioId { get; set; }
        public byte Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaCapacitacion { get; set; }
        public bool? StatusEmpleado { get; set; }
    }
}
