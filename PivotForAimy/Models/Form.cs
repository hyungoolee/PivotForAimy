using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Form
    {
        public Form()
        {
            FormField = new HashSet<FormField>();
            FormInstance = new HashSet<FormInstance>();
            FormTemplate = new HashSet<FormTemplate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<FormField> FormField { get; set; }
        public virtual ICollection<FormInstance> FormInstance { get; set; }
        public virtual ICollection<FormTemplate> FormTemplate { get; set; }
    }
}
