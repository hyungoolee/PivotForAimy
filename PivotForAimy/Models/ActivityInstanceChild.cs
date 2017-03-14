using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityInstanceChild
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ActivityInstanceId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual Child Child { get; set; }
    }
}
