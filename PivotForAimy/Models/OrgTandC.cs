using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgTandC
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string Code { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Org Org { get; set; }
    }
}
