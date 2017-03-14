using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Program
    {
        public Program()
        {
            ChildDiscount = new HashSet<ChildDiscount>();
            ProgramMedia = new HashSet<ProgramMedia>();
            ProgramSession = new HashSet<ProgramSession>();
            ProgramTags = new HashSet<ProgramTags>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
            SptInstance = new HashSet<SptInstance>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public int? ParentId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeName1 { get; set; }
        public string TimeName2 { get; set; }
        public string TimeName3 { get; set; }
        public string TimeName4 { get; set; }
        public string TimeName5 { get; set; }
        public string TimeName6 { get; set; }
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
        public string TimeDescription1 { get; set; }
        public string TimeDescription2 { get; set; }
        public string TimeDescription3 { get; set; }
        public string TimeDescription4 { get; set; }
        public string TimeDescription5 { get; set; }
        public string TimeDescription6 { get; set; }
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
        public string ImageUrl { get; set; }
        public int? Index { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? HolFullTimeItemCodeId { get; set; }
        public int? HolShortItemCodeId { get; set; }
        public int? HolTripItemCodeId { get; set; }
        public int? PartTimeItemCodeId { get; set; }
        public int? SpecialCodeId { get; set; }
        public int? HolPartTimeAmitemCodeId { get; set; }
        public int? HolPartTimePmitemCodeId { get; set; }
        public int? FullTimeItemCodeId { get; set; }
        public int? CasualItemCodeId { get; set; }
        public int? TrackingCatOptionId { get; set; }
        public int? CostType { get; set; }
        public bool? IsFullDay { get; set; }
        public int? Duration { get; set; }
        public string Color { get; set; }
        public int? Capacity { get; set; }
        public string Tags { get; set; }
        public int? Rating { get; set; }
        public int? ViewCount { get; set; }
        public int? WeeklySessionId { get; set; }
        public bool? IsChargeEarlyFee { get; set; }
        public bool? IsChargeLateFee { get; set; }
        public int? SignInMethodId { get; set; }
        public int? SignOutMethodId { get; set; }

        public virtual ICollection<ChildDiscount> ChildDiscount { get; set; }
        public virtual ICollection<ProgramMedia> ProgramMedia { get; set; }
        public virtual ICollection<ProgramSession> ProgramSession { get; set; }
        public virtual ICollection<ProgramTags> ProgramTags { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual ICollection<SptInstance> SptInstance { get; set; }
        public virtual XeroItemCode CasualItemCode { get; set; }
        public virtual ProgramCategory Category { get; set; }
        public virtual XeroItemCode FullTimeItemCode { get; set; }
        public virtual XeroItemCode HolFullTimeItemCode { get; set; }
        public virtual XeroItemCode HolPartTimeAmitemCode { get; set; }
        public virtual XeroItemCode HolPartTimePmitemCode { get; set; }
        public virtual XeroItemCode HolShortItemCode { get; set; }
        public virtual XeroItemCode HolTripItemCode { get; set; }
        public virtual Program Parent { get; set; }
        public virtual ICollection<Program> InverseParent { get; set; }
        public virtual XeroItemCode PartTimeItemCode { get; set; }
        public virtual Org Site { get; set; }
        public virtual XeroItemCode SpecialCode { get; set; }
        public virtual XeroTrackingCatOption TrackingCatOption { get; set; }
        public virtual Session WeeklySession { get; set; }
    }
}
