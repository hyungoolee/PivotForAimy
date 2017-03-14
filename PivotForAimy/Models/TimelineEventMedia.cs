using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TimelineEventMedia
    {
        public int Id { get; set; }
        public int MediaTypeId { get; set; }
        public int MediaId { get; set; }
        public int TimelineEventId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Media Media { get; set; }
        public virtual TimelineEvent TimelineEvent { get; set; }
    }
}
