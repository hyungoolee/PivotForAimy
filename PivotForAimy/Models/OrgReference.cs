using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgReference
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string Type { get; set; }
        public string Reference { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Org Org { get; set; }
    }
}
