using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SiteGroup
    {
        public SiteGroup()
        {
            ActivityInstance = new HashSet<ActivityInstance>();
            SiteGroupBookingSpt = new HashSet<SiteGroupBookingSpt>();
            SptSiteGroup = new HashSet<SptSiteGroup>();
        }

        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string UsageCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<ActivityInstance> ActivityInstance { get; set; }
        public virtual ICollection<SiteGroupBookingSpt> SiteGroupBookingSpt { get; set; }
        public virtual ICollection<SptSiteGroup> SptSiteGroup { get; set; }
        public virtual Org Site { get; set; }
    }
}
