using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgTesting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SchoolId { get; set; }
        public int? OldId { get; set; }
        public int InvRefSettingId { get; set; }
        public string CompanyName { get; set; }
        public int? TypeId { get; set; }
        public int? ParentId { get; set; }
        public int? TerritoryId { get; set; }
        public int? ContactId { get; set; }
        public int? Decile { get; set; }
        public int? Roll { get; set; }
        public int? RollApproved { get; set; }
        public DateTime? LeaseStart { get; set; }
        public DateTime? LeaseEnd { get; set; }
        public string LeasorName { get; set; }
        public decimal? LeaseCostFixed { get; set; }
        public string MeetingRoom { get; set; }
        public string BankAccNum { get; set; }
        public string MsdNum { get; set; }
        public string OscarNum { get; set; }
        public string Comments { get; set; }
        public string ExtraChargeType { get; set; }
        public decimal? ExtraMinRate { get; set; }
        public int? BeforeThreshold { get; set; }
        public int? AfterThreshold { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool HasSaved { get; set; }
        public byte[] Version { get; set; }
        public DateTime? LicenceStart { get; set; }
        public DateTime? LicenceEnd { get; set; }
        public decimal? WeeklyAdminCost { get; set; }
        public decimal? WeeklyRentCost { get; set; }
        public decimal? CurrentRevenue { get; set; }
        public decimal? CurrentExpenses { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? CurrentOverdueAmt { get; set; }
        public string MasterPin { get; set; }
        public bool? IsChildPhotoEnabled { get; set; }
        public bool? IsAuthPhotoEnabled { get; set; }
        public bool? IsStaffPhotoEnabled { get; set; }
        public bool? IsMultiSitePickupEnabled { get; set; }
        public bool? IsFreeTrial { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string StaffClockMethod { get; set; }
        public int? LeaseCostPercentage { get; set; }
        public bool? IsPaymentGatewayEnabled { get; set; }
        public string SiteBankAccNum { get; set; }
        public decimal? LicenceFee { get; set; }
        public bool? IsDashboardMsgEnabled { get; set; }
        public bool? IsEmailMsgEnabled { get; set; }
        public bool? IsSmsmsgEnabled { get; set; }
        public string SiteContactPersone { get; set; }
        public string SiteContactPhone { get; set; }
        public string SiteContactEmail { get; set; }
        public bool InvoiceDateSetting { get; set; }
        public string HeadOfficeLogo { get; set; }
        public bool? IsWizard { get; set; }
        public int? LastStep { get; set; }
        public bool? IsProgrammePriceVisible { get; set; }
        public bool? IsBookingPromoMsgVisible { get; set; }
        public string BookingPromotionMsg { get; set; }
        public bool? IsHolBookingPromoMsgVisible { get; set; }
        public string HolBookingPromoMsg { get; set; }
        public bool? IsSpecialBookingPromoMsgVisible { get; set; }
        public string SpecialBookingPromoMsg { get; set; }
        public string LoginUrl { get; set; }
        public bool ShowCustomisedBooking { get; set; }
        public int? InvoiceDay { get; set; }
        public int? InvoiceDueDays { get; set; }
        public int InvoiceGenDay { get; set; }
        public int InvoiceGenWeek { get; set; }
        public int InvoiceDueDay { get; set; }
        public int InvoiceDueWeek { get; set; }
        public int? CssbillingPlanId { get; set; }
        public DateTime? CssrevireDate { get; set; }
        public string Csscomment { get; set; }
        public string BookingInfoRegular { get; set; }
        public string BookingInfoCasual { get; set; }
        public bool? IsNew { get; set; }
        public int? CurrentStatus { get; set; }
        public string Logo { get; set; }
        public bool? AllowOverdueNotification { get; set; }
        public bool? IsCreditCardPaymentDisabled { get; set; }
        public int? NewChildFlagDays { get; set; }
        public bool? IsInvArrearBasedOnStart { get; set; }

        public virtual CssBillingPlan CssbillingPlan { get; set; }
        public virtual OrgTesting Parent { get; set; }
        public virtual ICollection<OrgTesting> InverseParent { get; set; }
    }
}
