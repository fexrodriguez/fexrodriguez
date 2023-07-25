using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityPerformanceReportsManufacturingMaster
    {
        public int Registro { get; set; }
        public string NumeroParte { get; set; }
        public string Familia { get; set; }
        public string Size { get; set; }
        public string NumeroSerie { get; set; }
        public string Tipo { get; set; }
        public string FechaProduccion { get; set; }
        public string Reg20 { get; set; }
        public string NombreCliente { get; set; }
        public string FechaVenta { get; set; }
        public double? SalesAmt { get; set; }
        public string Enviado { get; set; }
        public string Vinventa { get; set; }
        public string NumeroRam { get; set; }
        public string FechaRma { get; set; }
        public string CodigoRma { get; set; }
        public string CantidadRma { get; set; }
        public string NumeroReclamo { get; set; }
        public string FechaReclamo { get; set; }
        public string Vinreclamo { get; set; }
        public string Modelo { get; set; }
        public int? DiasUso { get; set; }
        public string PtsRcvd { get; set; }
        public string FechaInspeccion { get; set; }
        public string CodigoCompleto { get; set; }
        public string CodigoFalla { get; set; }
        public double? CargoAprobado { get; set; }
        public double? CargoRechazado { get; set; }
        public double? CargoProveedor { get; set; }
        public int? Aprobado { get; set; }
        public int? Rechazado { get; set; }
        public string NombreCargo { get; set; }
        public int? DiasAnterioresUso { get; set; }
        public double? Nfwpamt { get; set; }
        public string Nfwgyn { get; set; }
        public string Nfwp { get; set; }
        public double? EngineAmt { get; set; }
        public double? LaborAmt { get; set; }
        public double? FreightAmt { get; set; }
        public string CloseDate { get; set; }
        public string FieldRepair { get; set; }
        public string FieldRepairable { get; set; }
        public int? ClaimCount { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
