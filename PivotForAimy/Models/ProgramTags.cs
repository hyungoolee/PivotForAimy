using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProgramTags
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public string Tag { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual Program Program { get; set; }
    }
}
