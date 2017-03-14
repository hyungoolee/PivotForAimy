using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgCssBillingRule
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? BillingRuleId { get; set; }
        public string RuleName { get; set; }
        public decimal? Amount { get; set; }
        public int? Percentage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreratedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Version { get; set; }
        public bool? IsActive { get; set; }

        public virtual CssBillingRule1 BillingRule { get; set; }
        public virtual Org Org { get; set; }
    }
}
