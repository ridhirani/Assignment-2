using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class RrSalesOpp
    {
        public int SaleId { get; set; }
        public string SalesOpportunitySoname { get; set; }
        public string Buname { get; set; }
        public int? SoRegionId { get; set; }
        public string SalesOpportunityBusname { get; set; }
        public string SalesOpportunityDivname { get; set; }
        public int? SoMarketId { get; set; }
        public string PrjtType { get; set; }
        public string JobType { get; set; }
        public string SowName { get; set; }
        public decimal? PriDollarAmt { get; set; }
        public int? SoNumSites { get; set; }
        public decimal? UspGetSalesOpportunityData { get; set; }
        public string Phase { get; set; }
        public double? PhsPrc { get; set; }
        public decimal? SalesOpportunityWeightedAmount { get; set; }
        public string SalesOpportunityActiveSalesEmployee { get; set; }
        public DateTime? SalesOpportunitySoPhaseStartDate { get; set; }
        public string SalesOpportunitySalesEmployee { get; set; }
        public string SalesOpprotunityManager { get; set; }
        public DateTime? SalesOpportunitySoStartDate { get; set; }
        public DateTime? SalesOpportunitySoEndDate { get; set; }
        public DateTime? SalesOpportunitySoClosingDate { get; set; }
        public DateTime? SalesOpportunitySloEstWorkDate { get; set; }
        public string Intlevel { get; set; }
        public string SosStatus { get; set; }
        public string SosReason { get; set; }

        public virtual RrIkpBusinessUnit BunameNavigation { get; set; }
        public virtual RrIkpInterestLevel IntlevelNavigation { get; set; }
        public virtual RrIkpSalesJobOppType JobTypeNavigation { get; set; }
        public virtual RrIkpSalesOppPhase PhaseNavigation { get; set; }
        public virtual RrIkpSalesOppPhase PhsPrcNavigation { get; set; }
        public virtual RrIkpSalesOppPricing PriDollarAmtNavigation { get; set; }
        public virtual RrIkpProjectType PrjtTypeNavigation { get; set; }
        public virtual RrIkpDivision SalesOpportunityDivnameNavigation { get; set; }
        public virtual RrIkpMarket SoMarket { get; set; }
        public virtual RrIkpSalesOpportunity SoNumSitesNavigation { get; set; }
        public virtual RrIkpRegion SoRegion { get; set; }
        public virtual RrIkpSalesOppStatusReason SosReasonNavigation { get; set; }
        public virtual RrIkpSalesOppStatus SosStatusNavigation { get; set; }
        public virtual RrIkpScopeOfWork SowNameNavigation { get; set; }
    }
}
