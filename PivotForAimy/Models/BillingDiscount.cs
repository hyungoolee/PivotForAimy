using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BillingDiscount
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public int InvoiceNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public decimal TotalDiscount { get; set; }

        public virtual Billing Billing { get; set; }
    }
}
