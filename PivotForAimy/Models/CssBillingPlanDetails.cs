using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingPlanDetails
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int BillingRuleId { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public DateTime? StarteDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual CssBillingRule BillingRule { get; set; }
        public virtual CssBillingPlan Plan { get; set; }
    }
}
