using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDeviationsCapture
    {
        public int IdRegistro { get; set; }
        public byte DeviationType { get; set; }
        public int? PartCode { get; set; }
        public int? PlantaId { get; set; }
        public int? DepartamentoId { get; set; }
        public string WorkStationId { get; set; }
        public string DescriptionProccess { get; set; }
        public string OriginChange { get; set; }
        public string Description { get; set; }
        public byte Duartion { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LimitDate { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? EngineerId { get; set; }
        public byte? Status { get; set; }
        public int? UsuarioCierreId { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaAccion { get; set; }
        public string AccionCorrectiva { get; set; }
    }
}
