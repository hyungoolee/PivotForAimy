using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildDiscountHistoryLookup
    {
        public int Id { get; set; }
        public int ChildDiscId { get; set; }
        public int BookingId { get; set; }
        public int BillingId { get; set; }
        public int InvoiceLineId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual ChildDiscount ChildDisc { get; set; }
        public virtual InvoiceLine InvoiceLine { get; set; }
    }
}
