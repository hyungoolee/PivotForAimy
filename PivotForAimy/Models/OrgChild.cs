using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgChild
    {
        public int Id { get; set; }
        public int? ChildId { get; set; }
        public int? SiteId { get; set; }
        public DateTime? FirstAttendanceDate { get; set; }
        public bool? NewFlagDone { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsLock { get; set; }

        public virtual Child Child { get; set; }
        public virtual Org Site { get; set; }
    }
}
