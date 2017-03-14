using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserTimelineEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TimelineEventId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual TimelineEvent TimelineEvent { get; set; }
        public virtual User User { get; set; }
    }
}
