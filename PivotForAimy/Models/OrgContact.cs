using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgContact
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? ContactId { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Org Org { get; set; }
    }
}
