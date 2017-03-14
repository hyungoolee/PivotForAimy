using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingRule1
    {
        public CssBillingRule1()
        {
            CssBillingPlanDetails1 = new HashSet<CssBillingPlanDetails1>();
            OrgCssBillingRule = new HashSet<OrgCssBillingRule>();
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

        public virtual ICollection<CssBillingPlanDetails1> CssBillingPlanDetails1 { get; set; }
        public virtual ICollection<OrgCssBillingRule> OrgCssBillingRule { get; set; }
        public virtual CssLookup1 Type { get; set; }
    }
}
