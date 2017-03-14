using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityInstanceStaff
    {
        public int Id { get; set; }
        public int RosterId { get; set; }
        public int ActivityInstanceId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual StaffRoster Roster { get; set; }
    }
}
