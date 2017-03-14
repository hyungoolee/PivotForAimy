using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Timeline
    {
        public Timeline()
        {
            ChildTimeline = new HashSet<ChildTimeline>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int SourceTypeId { get; set; }
        public int? EntityId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
        public DateTime HappendOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ChildTimeline> ChildTimeline { get; set; }
        public virtual User User { get; set; }
    }
}
