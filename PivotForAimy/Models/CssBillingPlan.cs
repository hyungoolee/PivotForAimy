using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingPlan
    {
        public CssBillingPlan()
        {
            CssBillingPlanDetails = new HashSet<CssBillingPlanDetails>();
            OrgTesting = new HashSet<OrgTesting>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<CssBillingPlanDetails> CssBillingPlanDetails { get; set; }
        public virtual ICollection<OrgTesting> OrgTesting { get; set; }
    }
}
