using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FormField
    {
        public FormField()
        {
            FormFieldValue = new HashSet<FormFieldValue>();
        }

        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int? Page { get; set; }
        public string GroupType { get; set; }
        public int? GroupNo { get; set; }
        public int? Sequence { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string Font { get; set; }
        public int? Size { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<FormFieldValue> FormFieldValue { get; set; }
        public virtual Form Form { get; set; }
    }
}
