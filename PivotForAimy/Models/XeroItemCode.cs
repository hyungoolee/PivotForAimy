using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroItemCode
    {
        public XeroItemCode()
        {
            BillingExtra = new HashSet<BillingExtra>();
            Booking = new HashSet<Booking>();
            BookingSpt = new HashSet<BookingSpt>();
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            InvoiceHistoryLine = new HashSet<InvoiceHistoryLine>();
            InvoiceLine = new HashSet<InvoiceLine>();
            OrgSettingDefaultAsccitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultAscftitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultAscptitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultBsccitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultBscftitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultBscptitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultHolfitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultHolpamitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultHolppmitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultHolsitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultHoltitemCode = new HashSet<OrgSetting>();
            OrgSettingDefaultSpecialItemCode = new HashSet<OrgSetting>();
            ProgramCasualItemCode = new HashSet<Program>();
            ProgramFullTimeItemCode = new HashSet<Program>();
            ProgramHolFullTimeItemCode = new HashSet<Program>();
            ProgramHolPartTimeAmitemCode = new HashSet<Program>();
            ProgramHolPartTimePmitemCode = new HashSet<Program>();
            ProgramHolShortItemCode = new HashSet<Program>();
            ProgramHolTripItemCode = new HashSet<Program>();
            ProgramPartTimeItemCode = new HashSet<Program>();
            ProgramSpecialCode = new HashSet<Program>();
            ProgramSession = new HashSet<ProgramSession>();
            Session = new HashSet<Session>();
            SiteProgramTermCasualItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermFullTimeItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermHolFullTimeItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermHolPartTimeAmitemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermHolPartTimePmitemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermHolShortItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermHolTripItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermPartTimeItemCode = new HashSet<SiteProgramTerm>();
            SiteProgramTermSpecialItemCode = new HashSet<SiteProgramTerm>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public Guid XeroTransactionId { get; set; }
        public DateTime? XeroUpdatedDateUtc { get; set; }
        public string ItemCode { get; set; }
        public string SaleAccountCode { get; set; }
        public string Description { get; set; }
        public decimal? CostPrice { get; set; }
        public string ItemName { get; set; }
        public decimal? SalePrice { get; set; }
        public string CostAccountCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<BillingExtra> BillingExtra { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingSpt> BookingSpt { get; set; }
        public virtual ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual ICollection<InvoiceHistoryLine> InvoiceHistoryLine { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultAsccitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultAscftitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultAscptitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultBsccitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultBscftitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultBscptitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHolfitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHolpamitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHolppmitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHolsitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultHoltitemCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultSpecialItemCode { get; set; }
        public virtual ICollection<Program> ProgramCasualItemCode { get; set; }
        public virtual ICollection<Program> ProgramFullTimeItemCode { get; set; }
        public virtual ICollection<Program> ProgramHolFullTimeItemCode { get; set; }
        public virtual ICollection<Program> ProgramHolPartTimeAmitemCode { get; set; }
        public virtual ICollection<Program> ProgramHolPartTimePmitemCode { get; set; }
        public virtual ICollection<Program> ProgramHolShortItemCode { get; set; }
        public virtual ICollection<Program> ProgramHolTripItemCode { get; set; }
        public virtual ICollection<Program> ProgramPartTimeItemCode { get; set; }
        public virtual ICollection<Program> ProgramSpecialCode { get; set; }
        public virtual ICollection<ProgramSession> ProgramSession { get; set; }
        public virtual ICollection<Session> Session { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermCasualItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermFullTimeItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermHolFullTimeItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermHolPartTimeAmitemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermHolPartTimePmitemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermHolShortItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermHolTripItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermPartTimeItemCode { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTermSpecialItemCode { get; set; }
        public virtual Org Org { get; set; }
    }
}
