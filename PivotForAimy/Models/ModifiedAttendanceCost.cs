using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ModifiedAttendanceCost
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public int AttId { get; set; }
        public decimal OriginalCost { get; set; }
        public decimal NewCost { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Attendance Att { get; set; }
    }
}
