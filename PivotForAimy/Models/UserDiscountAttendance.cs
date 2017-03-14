using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserDiscountAttendance
    {
        public int Id { get; set; }
        public int AttendanceId { get; set; }
        public int UserDiscountRefId { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Attendance Attendance { get; set; }
    }
}
