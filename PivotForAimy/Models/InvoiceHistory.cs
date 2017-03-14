using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoiceHistory
    {
        public InvoiceHistory()
        {
            InvoiceHistoryLine = new HashSet<InvoiceHistoryLine>();
        }

        public int Id { get; set; }
        public int BillingId { get; set; }
        public int InvoiceIndex { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public DateTime FirstAtt { get; set; }
        public DateTime LastAtt { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<InvoiceHistoryLine> InvoiceHistoryLine { get; set; }
        public virtual Billing Billing { get; set; }
    }
}
