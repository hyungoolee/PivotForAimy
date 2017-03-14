using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class QuestionOption
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; }
        public string Hint { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Question Question { get; set; }
    }
}
