using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportTransit
    {
        public string Serial { get; set; }
        public string TruckNum { get; set; }
        public string Customer { get; set; }
        public string Tub { get; set; }
        public string CoNum { get; set; }
        public double? Coline { get; set; }
        public double? SCoRelease { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Shipped { get; set; }
        public string VegePartNumber { get; set; }
        public string TruckDate { get; set; }
        public string Price { get; set; }
    }
}
