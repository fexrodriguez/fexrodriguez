using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportStockorder
    {
        public string CustNum { get; set; }
        public string City { get; set; }
        public string ProvSt { get; set; }
        public string StockOrder { get; set; }
        public string OrderDate { get; set; }
        public string PoNumber { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public string Part { get; set; }
        public string DueDate { get; set; }
        public string Warehouse { get; set; }
        public double? QtyNeeded { get; set; }
        public double? QtyOrderedTotal { get; set; }
        public string StockQtyAvailable { get; set; }
        public double? QtyToOrder { get; set; }
        public string StockStatus { get; set; }
        public string StockMessage { get; set; }
    }
}
