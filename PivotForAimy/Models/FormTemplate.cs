using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FormTemplate
    {
        public FormTemplate()
        {
            FormInstance = new HashSet<FormInstance>();
        }

        public int Id { get; set; }
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Thumbnail { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<FormInstance> FormInstance { get; set; }
        public virtual Form Form { get; set; }
    }
}
