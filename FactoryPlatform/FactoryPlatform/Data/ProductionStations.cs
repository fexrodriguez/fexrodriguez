using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionStations
    {
        public int IdEstacion { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public int DepartamentoId { get; set; }
        public bool? RevisionDocPantalla { get; set; }
        public bool? RevisionDocCarpeta { get; set; }
        public int PlantaId { get; set; }
        public int? PlantaTiempoLaboradoId { get; set; }
        public int? UnidadNegocioId { get; set; }
        public int? PersonalRequerido { get; set; }
        public DateTime? FechaRegistroUnidadNegocio { get; set; }
        public int? UsuarioRegistroUnidadNegocioId { get; set; }
        public bool? ExamenAuditivo { get; set; }
        public int? UsuarioActivoExamen { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public bool? Status { get; set; }
    }
}
