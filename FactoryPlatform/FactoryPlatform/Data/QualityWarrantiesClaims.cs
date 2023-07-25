﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityWarrantiesClaims
    {
        public int IdRegistro { get; set; }
        public string Claim { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Ssr { get; set; }
        public string Ssrname { get; set; }
        public string Ssrsite { get; set; }
        public string Administrator { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSite { get; set; }
        public string Phone { get; set; }
        public string CallerName { get; set; }
        public string CallerAddress { get; set; }
        public string CallerMailingAddress { get; set; }
        public string CallerCity { get; set; }
        public string CallerState { get; set; }
        public string CallerZipCode { get; set; }
        public string Contact { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Customer { get; set; }
        public string ShipTo { get; set; }
        public string Unit { get; set; }
        public string UnitDescription { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string CustomerItem { get; set; }
        public string Qty { get; set; }
        public string Um { get; set; }
        public DateTime? MeterDate { get; set; }
        public string MeterAmt { get; set; }
        public string PriorIncident { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityCodeDescription { get; set; }
        public string StatusCode { get; set; }
        public string StatusCodeDescription { get; set; }
        public string ApprovalStatus { get; set; }
        public string WarrantyAdministratorApprovalStatus { get; set; }
        public DateTime? WarrantyInspectionApprovalDate { get; set; }
        public string Category { get; set; }
        public string OpenCode { get; set; }
        public string Wdcode { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? FollowupDate { get; set; }
        public DateTime? WarningDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string DestinationSite { get; set; }
        public string WAtkcore { get; set; }
        public string WAtkno { get; set; }
        public string WAuthorizedPartsRepaced { get; set; }
        public string WBillNo { get; set; }
        public string WBy { get; set; }
        public string WCarrier { get; set; }
        public string WCheckNo { get; set; }
        public string WChgTo { get; set; }
        public string WClaimDate { get; set; }
        public string WClaimEstablishedBy { get; set; }
        public string WClientsClaimNo { get; set; }
        public string WCnct { get; set; }
        public string WCondition { get; set; }
        public string ConditionReported { get; set; }
        public string WCreatedBy { get; set; }
        public string WCustomer { get; set; }
        public string WCustomerNo { get; set; }
        public string WCustPd { get; set; }
        public string WDateFail { get; set; }
        public string WDateInst { get; set; }
        public string WDateProc { get; set; }
        public DateTime? WDateRecd { get; set; }
        public string WDays { get; set; }
        public string WDuplicateClaim { get; set; }
        public string WEngineNo { get; set; }
        public string WFailureCode { get; set; }
        public string WFax { get; set; }
        public string WFreightIn { get; set; }
        public string WFrtin { get; set; }
        public string WFrtout { get; set; }
        public string WGarageAddress { get; set; }
        public string WGarageCity { get; set; }
        public string WGarageContactFirst { get; set; }
        public string WGarageFaxNo { get; set; }
        public string WGarageName { get; set; }
        public string WGaragePhone { get; set; }
        public string WGarageSt { get; set; }
        public string WGarageZip { get; set; }
        public string WGoodwillAmount { get; set; }
        public string WInspectionClaimNo { get; set; }
        public string WInspectionDate { get; set; }
        public string WInspector { get; set; }
        public string WLab { get; set; }
        public string WLabor { get; set; }
        public string WLaborRate { get; set; }
        public string WLaborTime { get; set; }
        public string WLaimno { get; set; }
        public string WMileFail { get; set; }
        public string WMileInst { get; set; }
        public string WModel { get; set; }
        public string WNetworkIsActive { get; set; }
        public string WPaymentGoesTo { get; set; }
        public string PartReplaced { get; set; }
        public string WReccomendEngine { get; set; }
        public string WReplacementSent { get; set; }
        public string WReportedFailure { get; set; }
        public string WSalesIsActive { get; set; }
        public string WSerialNo { get; set; }
        public string WShipInfoIsActive { get; set; }
        public string WShopLaborRate { get; set; }
        public string WStarlightNo { get; set; }
        public string WStoreAddress { get; set; }
        public string WStoreCity { get; set; }
        public string WStoreName { get; set; }
        public string WStorePhone { get; set; }
        public string WStoreSt { get; set; }
        public string WStoreZip { get; set; }
        public string ConditionReported1 { get; set; }
        public string WTime1 { get; set; }
        public string WTime2 { get; set; }
        public string WTotalPaid { get; set; }
        public string WTotalWGsa { get; set; }
        public string WTypeOfGoodwill { get; set; }
        public string WVehicleOwnerCellNo { get; set; }
        public string WVehicleOwnerName { get; set; }
        public string WVehicleOwnerPhone { get; set; }
        public string WVehicleOwnerSt { get; set; }
        public string WVehicleOwnerZip { get; set; }
        public string WVenChg { get; set; }
        public string WVehicleOwnerAddress { get; set; }
        public string WVinNo { get; set; }
        public string WWarrantyDays { get; set; }
        public string WWarrantyMiles { get; set; }
        public string ApprovalStatus1 { get; set; }
        public string PartReceivedDescription { get; set; }
        public string FactoryCode { get; set; }
        public string MilesInService { get; set; }
        public string DaysInService { get; set; }
        public string InspectionStatus { get; set; }
        public double? Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TrackIt { get; set; }
        public string Dtccode { get; set; }
        public string InspectionManagerUser { get; set; }
        public string InspectionSite { get; set; }
        public string InspectionReleaseDate { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string Nfwtype { get; set; }
        public string ConditionReported2 { get; set; }
        public string CDerBillAddressStatic { get; set; }
        public string SetStore { get; set; }
        public string CDerShipAddressStatic { get; set; }
        public string DeniedCallDate { get; set; }
        public string ComplaintCode { get; set; }
        public string Description1 { get; set; }
        public string TypePuchase { get; set; }
        public string StreetAddress { get; set; }
        public string PData { get; set; }
        public string VendorNotes { get; set; }
        public int? EmailClaimtoVendorwhenapplicable { get; set; }
        public int? ClaimEmailedtoVendor { get; set; }
        public DateTime? FechaRegistroUp { get; set; }
    }
}
