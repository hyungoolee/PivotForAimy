using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TimelineEvent
    {
        public TimelineEvent()
        {
            ChildTimelineEvent = new HashSet<ChildTimelineEvent>();
            TimelineEventMedia = new HashSet<TimelineEventMedia>();
            UserTimelineEvent = new HashSet<UserTimelineEvent>();
        }

        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public int EventTypeId { get; set; }
        public int? EntityId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int ProfileId { get; set; }
        public string ProfileImage { get; set; }
        public string ProfileName { get; set; }
        public bool IsActive { get; set; }
        public DateTime HappendOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ChildTimelineEvent> ChildTimelineEvent { get; set; }
        public virtual ICollection<TimelineEventMedia> TimelineEventMedia { get; set; }
        public virtual ICollection<UserTimelineEvent> UserTimelineEvent { get; set; }
    }
}
