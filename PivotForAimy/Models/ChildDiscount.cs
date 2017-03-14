using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildDiscount
    {
        public ChildDiscount()
        {
            AppliedDiscount = new HashSet<AppliedDiscount>();
            ChildDiscountHistoryLookup = new HashSet<ChildDiscountHistoryLookup>();
            SessionDiscount = new HashSet<SessionDiscount>();
        }

        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ProgramCateogryId { get; set; }
        public int? ProgramId { get; set; }
        public int SiteId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public decimal? FullTimeRate { get; set; }
        public decimal? PartTimeRate { get; set; }
        public decimal? CasualRate { get; set; }

        public virtual ICollection<AppliedDiscount> AppliedDiscount { get; set; }
        public virtual ICollection<ChildDiscountHistoryLookup> ChildDiscountHistoryLookup { get; set; }
        public virtual ICollection<SessionDiscount> SessionDiscount { get; set; }
        public virtual Child Child { get; set; }
        public virtual ProgramCategory ProgramCateogry { get; set; }
        public virtual Program Program { get; set; }
        public virtual Org Site { get; set; }
    }
}
