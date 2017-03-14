using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroEditBookingQueue
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int BillingId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual Org Org { get; set; }
    }
}
