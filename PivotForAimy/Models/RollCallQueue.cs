using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class RollCallQueue
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int AttendanceId { get; set; }
        public int ProgramCategoryType { get; set; }
        public int Method { get; set; }
        public int Direction { get; set; }
        public bool HasAttended { get; set; }
        public DateTime? ActualStart { get; set; }
        public string ActualStartKeyedBy { get; set; }
        public string SignedInBy { get; set; }
        public DateTime? ActualStartKeyedOn { get; set; }
        public string AbsentReason { get; set; }
        public DateTime? ActualEnd { get; set; }
        public string ActualEndKeyedBy { get; set; }
        public DateTime? ActualEndKeyedOn { get; set; }
        public string SignedBy { get; set; }
        public int? SignatureId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsProceed { get; set; }
        public DateTime? ProceedOn { get; set; }
        public string ErrorMsg { get; set; }

        public virtual Attendance Attendance { get; set; }
        public virtual Child Child { get; set; }
        public virtual SignoutSignature Signature { get; set; }
    }
}
