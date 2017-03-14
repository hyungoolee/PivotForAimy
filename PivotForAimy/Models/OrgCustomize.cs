using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgCustomize
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public bool? IsXeroEnabled { get; set; }
        public bool? ShowCustomisedBooking { get; set; }
        public bool? ShowSiteSetupNetwork { get; set; }
        public bool? IsSubsidyEnabled { get; set; }
        public string SchoolInfo { get; set; }
        public string Ethinicity { get; set; }
        public string TermsAndCondition { get; set; }
        public string ChildSignoutMethod { get; set; }
        public string Xml { get; set; }
        public string Url { get; set; }
        public bool? ShowHolidayProgram { get; set; }
        public bool? ShowSpecialProgram { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool? ShowStaffTitles { get; set; }
        public bool? ShowDriverRole { get; set; }
        public bool? ShowProgMgrRole { get; set; }
        public bool? AllowBookOnWeekend { get; set; }
        public bool? Is24HourClockFormat { get; set; }
        public bool? ShowSingleRate { get; set; }
        public bool? ShowImageOnBookingTemp { get; set; }
        public bool? CanMarkAsPaid { get; set; }
        public bool? ShowChildNoteOnMgmt { get; set; }
        public string HowHear { get; set; }
        public int? CountryId { get; set; }
        public bool? ShowMyStats { get; set; }
        public bool? ShowNetworkStats { get; set; }
        public bool? ShowAchievementTracking { get; set; }
        public bool? ShowSiteSelectionOnEnrollment { get; set; }
        public bool? HideDateRangeBooking { get; set; }
        public bool? ShowDrivingLicence { get; set; }
        public bool? ShowPermanentKeyOnBookingType { get; set; }
        public bool? IsClassEnabled { get; set; }
        public decimal? TimezoneOffset { get; set; }
        public bool? ShowOscarIntendedAtBooking { get; set; }
        public bool? ExcludeDaysChargeable { get; set; }
        public bool? DisableWinzonForm { get; set; }
        public bool? AllowIncompleteExpressRegister { get; set; }
        public string Timezone { get; set; }
        public int? FinanceModuleType { get; set; }
        public string CurrencySymbol { get; set; }
        public string CountryCode { get; set; }
        public bool? ShowBillingSetting { get; set; }
        public string TaxName { get; set; }
        public decimal? TaxRate { get; set; }
        public string Culture { get; set; }

        public virtual Country Country { get; set; }
        public virtual Org Org { get; set; }
    }
}
