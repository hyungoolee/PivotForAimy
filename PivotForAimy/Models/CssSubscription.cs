using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssSubscription
    {
        public CssSubscription()
        {
            CssBilling = new HashSet<CssBilling>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public int? BillingPlanDetailId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool? PayAll { get; set; }
        public bool? PayOnlySite { get; set; }

        public virtual ICollection<CssBilling> CssBilling { get; set; }
        public virtual CssBillingPlanDetails1 BillingPlanDetail { get; set; }
        public virtual Org Org { get; set; }
    }
}
