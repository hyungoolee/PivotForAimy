using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityCondition
    {
        public int Id { get; set; }
        public int ConditionId { get; set; }
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Condition Condition { get; set; }
    }
}
