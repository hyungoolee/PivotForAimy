using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildCondition
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int? ConditionId { get; set; }
        public string OtherName { get; set; }
        public int? OtherTypeId { get; set; }
        public string Severity { get; set; }
        public string DoctorName { get; set; }
        public string DoctorContact { get; set; }
        public string Symptoms { get; set; }
        public string TreatmentDesc { get; set; }
        public string MedicationDesc { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Child Child { get; set; }
        public virtual Condition Condition { get; set; }
    }
}
