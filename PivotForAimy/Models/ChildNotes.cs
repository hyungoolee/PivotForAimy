using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildNotes
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Child Child { get; set; }
    }
}
