using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingRule
    {
        public CssBillingRule()
        {
            CssBillingPlanDetails = new HashSet<CssBillingPlanDetails>();
        }

        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Formula { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CssBillingPlanDetails> CssBillingPlanDetails { get; set; }
        public virtual CssLookup Type { get; set; }
    }
}
