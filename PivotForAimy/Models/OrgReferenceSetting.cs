using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgReferenceSetting
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string ReferenceMessage { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Org Org { get; set; }
    }
}
