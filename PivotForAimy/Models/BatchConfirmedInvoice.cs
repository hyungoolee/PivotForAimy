using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BatchConfirmedInvoice
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int BillingId { get; set; }
        public bool IsProcessed { get; set; }
        public bool Error { get; set; }
        public string ErrorDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
