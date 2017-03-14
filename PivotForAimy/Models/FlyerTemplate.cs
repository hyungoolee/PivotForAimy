using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FlyerTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SiteId { get; set; }
        public string FileName { get; set; }
        public string NewFileName { get; set; }
        public int? MinItemCount { get; set; }
        public int? MaxItemCount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Org Site { get; set; }
    }
}
