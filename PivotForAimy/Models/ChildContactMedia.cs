using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildContactMedia
    {
        public int Id { get; set; }
        public int ChildContactId { get; set; }
        public int MediaId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ChildContact ChildContact { get; set; }
        public virtual Media Media { get; set; }
    }
}
