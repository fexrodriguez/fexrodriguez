using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsProvidersItems
    {
        public int IdregistroProvider { get; set; }
        public int? ProveedorId { get; set; }
        public int? ArticuloId { get; set; }
        public string ItemVendor { get; set; }
        public decimal? Clasificacion { get; set; }
        public decimal? TiempoEntrega { get; set; }
        public DateTime? FechaCotizacion { get; set; }
        public decimal? CostoPromedio { get; set; }
        public DateTime? FechaUltimaOrden { get; set; }
        public decimal? UltimoCosto { get; set; }
        public string Moneda { get; set; }
        public string DescripcionMoneda { get; set; }
        public string AcuerdoCompromiso { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public int? PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
