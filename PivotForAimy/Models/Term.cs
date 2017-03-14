using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Term
    {
        public Term()
        {
            Billing = new HashSet<Billing>();
            OrgGroup = new HashSet<OrgGroup>();
            OscarCoCTermHoliday = new HashSet<OscarCoC>();
            OscarCoCTerm = new HashSet<OscarCoC>();
            OscarDeclarationTermHoliday = new HashSet<OscarDeclaration>();
            OscarDeclarationTerm = new HashSet<OscarDeclaration>();
            OscarRenewalFormTrackingTermHoliday = new HashSet<OscarRenewalFormTracking>();
            OscarRenewalFormTrackingTerm = new HashSet<OscarRenewalFormTracking>();
            OscarTrackingTermHoliday = new HashSet<OscarTracking>();
            OscarTrackingTerm = new HashSet<OscarTracking>();
            OscarTrackingChild = new HashSet<OscarTrackingChild>();
            SiteProgramTerm = new HashSet<SiteProgramTerm>();
            SptInstance = new HashSet<SptInstance>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int Year { get; set; }
        public bool? IsHoliday { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool HasSaved { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? DefaultTermId { get; set; }

        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<OrgGroup> OrgGroup { get; set; }
        public virtual ICollection<OscarCoC> OscarCoCTermHoliday { get; set; }
        public virtual ICollection<OscarCoC> OscarCoCTerm { get; set; }
        public virtual ICollection<OscarDeclaration> OscarDeclarationTermHoliday { get; set; }
        public virtual ICollection<OscarDeclaration> OscarDeclarationTerm { get; set; }
        public virtual ICollection<OscarRenewalFormTracking> OscarRenewalFormTrackingTermHoliday { get; set; }
        public virtual ICollection<OscarRenewalFormTracking> OscarRenewalFormTrackingTerm { get; set; }
        public virtual ICollection<OscarTracking> OscarTrackingTermHoliday { get; set; }
        public virtual ICollection<OscarTracking> OscarTrackingTerm { get; set; }
        public virtual ICollection<OscarTrackingChild> OscarTrackingChild { get; set; }
        public virtual ICollection<SiteProgramTerm> SiteProgramTerm { get; set; }
        public virtual ICollection<SptInstance> SptInstance { get; set; }
        public virtual Term DefaultTerm { get; set; }
        public virtual ICollection<Term> InverseDefaultTerm { get; set; }
        public virtual Org Site { get; set; }
    }
}
