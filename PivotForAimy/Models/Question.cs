using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionOption = new HashSet<QuestionOption>();
        }

        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int TrainingModuleId { get; set; }
        public int Type { get; set; }
        public int NumberOfOptions { get; set; }
        public string MoreDetails { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<QuestionOption> QuestionOption { get; set; }
        public virtual TrainingModule TrainingModule { get; set; }
    }
}
