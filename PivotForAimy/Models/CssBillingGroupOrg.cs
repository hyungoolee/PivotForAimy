using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingGroupOrg
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int BillingGroupId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual CssBillingGroup BillingGroup { get; set; }
        public virtual Org Org { get; set; }
    }
}
