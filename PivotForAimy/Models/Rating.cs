using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Comment { get; set; }
        public int? Grade { get; set; }

        public virtual Activity Activity { get; set; }
    }
}
