using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class RollCallHistory
    {
        public int Id { get; set; }
        public int AttendanceId { get; set; }
        public int ActionId { get; set; }
        public DateTime HappenedOn { get; set; }
        public DateTime KeyedOn { get; set; }
        public string KeyedBy { get; set; }
        public string SignedBy { get; set; }
        public int? SignatureId { get; set; }
        public string AbsentReason { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Attendance Attendance { get; set; }
    }
}
