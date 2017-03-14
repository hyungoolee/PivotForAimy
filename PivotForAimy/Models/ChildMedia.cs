using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildMedia
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int MediaId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Child Child { get; set; }
        public virtual Media Media { get; set; }
    }
}
