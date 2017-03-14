using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Condition
    {
        public Condition()
        {
            ActivityCondition = new HashSet<ActivityCondition>();
            ActivityInstanceCondition = new HashSet<ActivityInstanceCondition>();
            ChildCondition = new HashSet<ChildCondition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string Treatment { get; set; }

        public virtual ICollection<ActivityCondition> ActivityCondition { get; set; }
        public virtual ICollection<ActivityInstanceCondition> ActivityInstanceCondition { get; set; }
        public virtual ICollection<ChildCondition> ChildCondition { get; set; }
    }
}
