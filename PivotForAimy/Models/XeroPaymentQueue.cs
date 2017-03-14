using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroPaymentQueue
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public int OrgId { get; set; }
        public bool IsProcessed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Org Org { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
