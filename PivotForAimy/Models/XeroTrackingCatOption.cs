using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroTrackingCatOption
    {
        public XeroTrackingCatOption()
        {
            BillingExtra = new HashSet<BillingExtra>();
            Booking = new HashSet<Booking>();
            BookingSpt = new HashSet<BookingSpt>();
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            InvoiceHistoryLine = new HashSet<InvoiceHistoryLine>();
            InvoiceLine = new HashSet<InvoiceLine>();
            OrgSettingDefaultAsctracking = new HashSet<OrgSetting>();
            OrgSettingDefaultBsctracking = new HashSet<OrgSetting>();
            OrgSettingDefaultHolTracking = new HashSet<OrgSetting>();
            OrgSettingDefaultSpecialTracking = new HashSet<OrgSetting>();
            Program = new HashSet<Program>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
            SubsidyPayment = new HashSet<SubsidyPayment>();
        }

        public int Id { get; set; }
        public int TrackingCatId { get; set; }
        public Guid? XeroTrackingCatOptId { get; set; }
        public string CatOptName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<BillingExtra> BillingExtra { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingSpt> BookingSpt { get; set; }
        public virtual ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual ICollection<InvoiceHistoryLine> InvoiceHistoryLine { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultAsctracking { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultBsctracking { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHolTracking { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultSpecialTracking { get; set; }
        public virtual ICollection<Program> Program { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual XeroTrackingCategory TrackingCat { get; set; }
    }
}
