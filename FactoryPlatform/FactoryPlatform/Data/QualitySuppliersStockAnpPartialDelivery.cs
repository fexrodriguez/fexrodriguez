using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualitySuppliersStockAnpPartialDelivery
    {
        public int IdRegistro { get; set; }
        public int InventoryId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int Qtydelivery { get; set; }
        public string Comments { get; set; }
        public int? EngineerId { get; set; }
        public string Voucher { get; set; }
    }
}
