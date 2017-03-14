using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroSubsidyPaymentQueue
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int SubsidyPaymentId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Org { get; set; }
        public virtual SubsidyPayment SubsidyPayment { get; set; }
    }
}
