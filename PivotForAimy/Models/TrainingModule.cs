using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TrainingModule
    {
        public TrainingModule()
        {
            OrgTrainingModule = new HashSet<OrgTrainingModule>();
            Question = new HashSet<Question>();
            RoleTrainingModule = new HashSet<RoleTrainingModule>();
            UserTrainingModule = new HashSet<UserTrainingModule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? HasQuestion { get; set; }

        public virtual ICollection<OrgTrainingModule> OrgTrainingModule { get; set; }
        public virtual ICollection<Question> Question { get; set; }
        public virtual ICollection<RoleTrainingModule> RoleTrainingModule { get; set; }
        public virtual ICollection<UserTrainingModule> UserTrainingModule { get; set; }
    }
}
