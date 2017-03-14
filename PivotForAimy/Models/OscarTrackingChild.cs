using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarTrackingChild
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int UserId { get; set; }
        public int ChildId { get; set; }
        public int TermId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Child Child { get; set; }
        public virtual Org Site { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
    }
}
