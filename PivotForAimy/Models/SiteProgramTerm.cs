using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SiteProgramTerm
    {
        public SiteProgramTerm()
        {
            ActivityInstance = new HashSet<ActivityInstance>();
            BookingSpt = new HashSet<BookingSpt>();
            HolidayFlyerDraft = new HashSet<HolidayFlyerDraft>();
            OrgGroup = new HashSet<OrgGroup>();
            OscarDelarationChild = new HashSet<OscarDelarationChild>();
            SptExcludeDays = new HashSet<SptExcludeDays>();
            SptInstance = new HashSet<SptInstance>();
            SptSession = new HashSet<SptSession>();
            SptSiteGroup = new HashSet<SptSiteGroup>();
            WaitingList = new HashSet<WaitingList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentSptId { get; set; }
        public int SiteId { get; set; }
        public int TermId { get; set; }
        public int? ProgramId { get; set; }
        public int? ManagerId { get; set; }
        public int? ProgramCategoryId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Year { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public TimeSpan? TimeStart1 { get; set; }
        public TimeSpan? TimeStart2 { get; set; }
        public TimeSpan? TimeStart3 { get; set; }
        public TimeSpan? TimeStart4 { get; set; }
        public TimeSpan? TimeStart5 { get; set; }
        public TimeSpan? TimeStart6 { get; set; }
        public TimeSpan? TimeEnd1 { get; set; }
        public TimeSpan? TimeEnd2 { get; set; }
        public TimeSpan? TimeEnd3 { get; set; }
        public TimeSpan? TimeEnd4 { get; set; }
        public TimeSpan? TimeEnd5 { get; set; }
        public TimeSpan? TimeEnd6 { get; set; }
        public decimal? RateFullTime { get; set; }
        public decimal? RatePartTime { get; set; }
        public decimal? RateCasual { get; set; }
        public decimal? Rate1 { get; set; }
        public decimal? Rate2 { get; set; }
        public decimal? Rate3 { get; set; }
        public decimal? Rate4 { get; set; }
        public decimal? Rate5 { get; set; }
        public decimal? Rate6 { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool? Published { get; set; }
        public DateTime? PublishedDate { get; set; }
        public byte[] Version { get; set; }
        public string ImgUrl { get; set; }
        public string TimeName1 { get; set; }
        public string TimeName2 { get; set; }
        public string TimeName3 { get; set; }
        public string TimeName4 { get; set; }
        public string TimeName5 { get; set; }
        public string TimeName6 { get; set; }
        public string TimeDescription1 { get; set; }
        public string TimeDescription2 { get; set; }
        public string TimeDescription3 { get; set; }
        public string TimeDescription4 { get; set; }
        public string TimeDescription5 { get; set; }
        public string TimeDescription6 { get; set; }
        public int? Index { get; set; }
        public int? FullTimeItemCodeId { get; set; }
        public int? PartTimeItemCodeId { get; set; }
        public int? CasualItemCodeId { get; set; }
        public int? HolFullTimeItemCodeId { get; set; }
        public int? HolPartTimeAmitemCodeId { get; set; }
        public int? HolPartTimePmitemCodeId { get; set; }
        public int? HolShortItemCodeId { get; set; }
        public int? HolTripItemCodeId { get; set; }
        public int? TrackingCatOptionId { get; set; }
        public int? SpecialItemCodeId { get; set; }
        public bool? IsFullDay { get; set; }

        public virtual ICollection<ActivityInstance> ActivityInstance { get; set; }
        public virtual ICollection<BookingSpt> BookingSpt { get; set; }
        public virtual ICollection<HolidayFlyerDraft> HolidayFlyerDraft { get; set; }
        public virtual ICollection<OrgGroup> OrgGroup { get; set; }
        public virtual ICollection<OscarDelarationChild> OscarDelarationChild { get; set; }
        public virtual ICollection<SptExcludeDays> SptExcludeDays { get; set; }
        public virtual ICollection<SptInstance> SptInstance { get; set; }
        public virtual ICollection<SptSession> SptSession { get; set; }
        public virtual ICollection<SptSiteGroup> SptSiteGroup { get; set; }
        public virtual ICollection<WaitingList> WaitingList { get; set; }
        public virtual XeroItemCode CasualItemCode { get; set; }
        public virtual XeroItemCode FullTimeItemCode { get; set; }
        public virtual XeroItemCode HolFullTimeItemCode { get; set; }
        public virtual XeroItemCode HolPartTimeAmitemCode { get; set; }
        public virtual XeroItemCode HolPartTimePmitemCode { get; set; }
        public virtual XeroItemCode HolShortItemCode { get; set; }
        public virtual XeroItemCode HolTripItemCode { get; set; }
        public virtual User Manager { get; set; }
        public virtual SiteProgramTerm ParentSpt { get; set; }
        public virtual ICollection<SiteProgramTerm> InverseParentSpt { get; set; }
        public virtual XeroItemCode PartTimeItemCode { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual Program Program { get; set; }
        public virtual Org Site { get; set; }
        public virtual XeroItemCode SpecialItemCode { get; set; }
        public virtual Term Term { get; set; }
        public virtual XeroTrackingCatOption TrackingCatOption { get; set; }
    }
}
