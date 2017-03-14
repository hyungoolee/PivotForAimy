using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingAudit
    {
        public int Id { get; set; }
        public int? BillingId { get; set; }
        public string XmlOld { get; set; }
        public string XmlNew { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public string Caller { get; set; }
        public Guid TransactionId { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}
