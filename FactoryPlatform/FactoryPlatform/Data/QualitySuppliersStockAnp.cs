using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualitySuppliersStockAnp
    {
        public int IdRegistro { get; set; }
        public string Codigo { get; set; }
        public string PartNumber { get; set; }
        public int ProveedorId { get; set; }
        public int Qty { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public byte Status { get; set; }
        public string Po { get; set; }
        public int ApplicantId { get; set; }
        public byte? AnpOpen { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int? UsuarioEntregaId { get; set; }
        public string Comments { get; set; }
        public bool? Sytline { get; set; }
        public int? CompradorId { get; set; }
        public int? PurchaseId { get; set; }
        public int? QtyOrigen { get; set; }
    }
}
