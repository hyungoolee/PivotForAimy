using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class HeadCount
    {
        public HeadCount()
        {
            HeadCountLine = new HashSet<HeadCountLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? SiteId { get; set; }
        public DateTime? Day { get; set; }
        public int? TotalCount { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string ProgramName { get; set; }
        public string GroupName { get; set; }
        public string SessionName { get; set; }

        public virtual ICollection<HeadCountLine> HeadCountLine { get; set; }
        public virtual Org Site { get; set; }
    }
}
