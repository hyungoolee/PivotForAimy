using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SiteDpsdetail
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string PxPayUserId { get; set; }
        public string PxPayKey { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Org Site { get; set; }
    }
}
