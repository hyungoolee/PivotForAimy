using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FormFieldValue
    {
        public int Id { get; set; }
        public int FormInstanceId { get; set; }
        public int FormFieldId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual FormField FormField { get; set; }
        public virtual FormInstance FormInstance { get; set; }
    }
}
