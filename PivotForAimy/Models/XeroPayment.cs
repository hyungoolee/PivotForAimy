using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroPayment
    {
        public int Id { get; set; }
        public int XeroInvoiceId { get; set; }
        public Guid XeroPaymentId { get; set; }
        public string Status { get; set; }
        public string Reference { get; set; }
        public DateTime? XeroLastUpdatedUtc { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual XeroInvoice XeroInvoice { get; set; }
    }
}
