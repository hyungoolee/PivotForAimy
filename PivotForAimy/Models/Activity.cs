using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityCondition = new HashSet<ActivityCondition>();
            ActivityInstance = new HashSet<ActivityInstance>();
            ActivityItem = new HashSet<ActivityItem>();
            RatingNavigation = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NoOfChild { get; set; }
        public int? NoOfStaff { get; set; }
        public bool IsPrivate { get; set; }
        public int? DurationMin { get; set; }
        public bool HasSaved { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string Review { get; set; }
        public int? Rating { get; set; }
        public string Instruction { get; set; }
        public decimal? Budget { get; set; }
        public decimal? CostPerChild { get; set; }
        public bool? IsFavourite { get; set; }

        public virtual ICollection<ActivityCondition> ActivityCondition { get; set; }
        public virtual ICollection<ActivityInstance> ActivityInstance { get; set; }
        public virtual ICollection<ActivityItem> ActivityItem { get; set; }
        public virtual ICollection<Rating> RatingNavigation { get; set; }
        public virtual Lookup Category { get; set; }
        public virtual Org Site { get; set; }
    }
}
