using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class StaffRosterHistory
    {
        public int Id { get; set; }
        public int RosterId { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Notes { get; set; }
        public string Reference { get; set; }
        public bool? IsClockInOutPaid { get; set; }

        public virtual StaffRoster Roster { get; set; }
    }
}
