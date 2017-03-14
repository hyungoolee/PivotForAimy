using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FormInstance
    {
        public FormInstance()
        {
            FormFieldValue = new HashSet<FormFieldValue>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public int FormId { get; set; }
        public int FormTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<FormFieldValue> FormFieldValue { get; set; }
        public virtual Form Form { get; set; }
        public virtual FormTemplate FormTemplate { get; set; }
    }
}
