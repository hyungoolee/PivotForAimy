using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class EventDuration
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string EventCode { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime? FinishOn { get; set; }
        public bool? IsSync { get; set; }
        public DateTime? SyncOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual User Staff { get; set; }
    }
}
