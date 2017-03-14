using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBillingGroup
    {
        public CssBillingGroup()
        {
            CssBillingGroupOrg = new HashSet<CssBillingGroupOrg>();
        }

        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? ParentGroupId { get; set; }
        public int? UserId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<CssBillingGroupOrg> CssBillingGroupOrg { get; set; }
        public virtual Org Org { get; set; }
        public virtual CssBillingGroup ParentGroup { get; set; }
        public virtual ICollection<CssBillingGroup> InverseParentGroup { get; set; }
    }
}
