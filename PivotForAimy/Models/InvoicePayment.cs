using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoicePayment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Guid XeroPaymentId { get; set; }
        public decimal? Amount { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public DateTime XeroUpdatedDateUtc { get; set; }
        public DateTime XeroDateCreated { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
