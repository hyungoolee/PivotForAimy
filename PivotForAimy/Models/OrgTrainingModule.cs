using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgTrainingModule
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public int OrgId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TrainingModule Module { get; set; }
        public virtual Org Org { get; set; }
    }
}
