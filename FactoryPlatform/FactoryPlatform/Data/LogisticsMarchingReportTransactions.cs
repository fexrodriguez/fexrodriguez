using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportTransactions
    {
        public double? TransactionNumber { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public double? Quantity { get; set; }
        public string ReferenceType { get; set; }
        public string RefNumber { get; set; }
        public double? RefLine { get; set; }
        public string ProductCode { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string TransactionDescription { get; set; }
        public string FromSite { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public string ItemUM { get; set; }
        public string MaterialCost { get; set; }
        public double? LaborCost { get; set; }
        public double? FovhdCost { get; set; }
        public double? VovhdCost { get; set; }
        public double? OutsideCost { get; set; }
        public string UnitCost { get; set; }
        public string TotalPosted { get; set; }
        public string DateAndTimeOfTrans { get; set; }
        public string DocumentNumber { get; set; }
        public string User { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CostCode { get; set; }
        public double? Employee { get; set; }
        public string WorkCenter { get; set; }
        public string Lot { get; set; }
        public double? RefRelease { get; set; }
        public double? Backflush { get; set; }
        public string BrokerAdjustment { get; set; }
    }
}
