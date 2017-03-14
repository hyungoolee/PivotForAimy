using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityInstanceCondition
    {
        public int Id { get; set; }
        public int ActivityInstanceId { get; set; }
        public int ConditionId { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual Condition Condition { get; set; }
    }
}
