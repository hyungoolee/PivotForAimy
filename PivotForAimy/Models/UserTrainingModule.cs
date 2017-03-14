using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserTrainingModule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingModuleId { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int LastSavedAnswer { get; set; }

        public virtual TrainingModule TrainingModule { get; set; }
        public virtual User User { get; set; }
    }
}
