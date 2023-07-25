using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityWarrantiesByMonth
    {
        public int IdRegistro { get; set; }
        public string NumeroClaim { get; set; }
        public string NumeroSro { get; set; }
        public string NumeroEngineSerial { get; set; }
        public string Prefix { get; set; }
        public string NumeroMfgPart { get; set; }
        public string Dato13yr { get; set; }
        public string ApprovalStatus { get; set; }
        public string NumeroParte { get; set; }
        public double? ProductCost { get; set; }
        public double? Otro { get; set; }
        public double? Factory { get; set; }
        public double? CoreMarketValue { get; set; }
        public string PartRcv { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? ClaimDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string MileageAtFailure { get; set; }
        public string FailureCode { get; set; }
        public string WhoCourtesyInsp { get; set; }
        public DateTime? CloseDate { get; set; }
        public string MonthOfClose { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime? FechaRegistroUp { get; set; }
    }
}
