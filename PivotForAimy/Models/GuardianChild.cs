using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class GuardianChild
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GuardianId { get; set; }
        public int ChildId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Child Child { get; set; }
        public virtual Contact Guardian { get; set; }
    }
}
