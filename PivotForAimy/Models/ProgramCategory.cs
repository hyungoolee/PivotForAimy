using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProgramCategory
    {
        public ProgramCategory()
        {
            Booking = new HashSet<Booking>();
            ChildDiscount = new HashSet<ChildDiscount>();
            DashboardViewHistory = new HashSet<DashboardViewHistory>();
            OrgBillingSetting = new HashSet<OrgBillingSetting>();
            OrgGroup = new HashSet<OrgGroup>();
            OrgStandardDiscount = new HashSet<OrgStandardDiscount>();
            Program = new HashSet<Program>();
            RollOverParent = new HashSet<RollOverParent>();
            SiteNotes = new HashSet<SiteNotes>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrgId { get; set; }
        public int? BookingTemplateId { get; set; }
        public string Code { get; set; }
        public bool? IsApprovedByMinistrySocialDev { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public int? TypeId { get; set; }
        public int? SignInStrategyId { get; set; }
        public int? SignOutStrategyId { get; set; }
        public int? SignInMethodId { get; set; }
        public int? SignOutMethodId { get; set; }
        public bool? AllowDriverPickup { get; set; }
        public bool? AllowOnsitePickup { get; set; }
        public bool? HasSession { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<ChildDiscount> ChildDiscount { get; set; }
        public virtual ICollection<DashboardViewHistory> DashboardViewHistory { get; set; }
        public virtual ICollection<OrgBillingSetting> OrgBillingSetting { get; set; }
        public virtual ICollection<OrgGroup> OrgGroup { get; set; }
        public virtual ICollection<OrgStandardDiscount> OrgStandardDiscount { get; set; }
        public virtual ICollection<Program> Program { get; set; }
        public virtual ICollection<RollOverParent> RollOverParent { get; set; }
        public virtual ICollection<SiteNotes> SiteNotes { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual Lookup BookingTemplate { get; set; }
        public virtual Org Org { get; set; }
        public virtual Lookup SignInMethod { get; set; }
        public virtual Lookup SignInStrategy { get; set; }
        public virtual Lookup SignOutMethod { get; set; }
        public virtual Lookup SignOutStrategy { get; set; }
        public virtual Lookup Type { get; set; }
    }
}
