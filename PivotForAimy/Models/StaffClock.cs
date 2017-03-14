using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class StaffClock
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string EventCode { get; set; }
        public DateTime Time { get; set; }
        public bool? IsSync { get; set; }
        public DateTime? SyncOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }

        public virtual User Staff { get; set; }
    }
}
