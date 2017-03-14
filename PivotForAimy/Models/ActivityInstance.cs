using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityInstance
    {
        public ActivityInstance()
        {
            ActivityInstanceChild = new HashSet<ActivityInstanceChild>();
            ActivityInstanceCondition = new HashSet<ActivityInstanceCondition>();
            ActivityInstanceStaff = new HashSet<ActivityInstanceStaff>();
        }

        public int Id { get; set; }
        public int SptId { get; set; }
        public int ActivityId { get; set; }
        public int SiteGroupId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int? DurationMin { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string RecurrenceType { get; set; }

        public virtual ICollection<ActivityInstanceChild> ActivityInstanceChild { get; set; }
        public virtual ICollection<ActivityInstanceCondition> ActivityInstanceCondition { get; set; }
        public virtual ICollection<ActivityInstanceStaff> ActivityInstanceStaff { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual SiteGroup SiteGroup { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
    }
}
