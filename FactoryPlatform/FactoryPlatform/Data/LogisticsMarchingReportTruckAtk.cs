using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportTruckAtk
    {
        public double? Pack { get; set; }
        public string Trlr { get; set; }
        public string DeliveryFromVmc { get; set; }
        public string ArrivedToAsk { get; set; }
        public double? TransitTime { get; set; }
        public double? Transito { get; set; }
    }
}
