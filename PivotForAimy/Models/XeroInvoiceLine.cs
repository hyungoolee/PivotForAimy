using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroInvoiceLine
    {
        public int Id { get; set; }
        public int XeroInvoiceId { get; set; }
        public Guid XeroLineItemId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public string ItemCode { get; set; }
        public string AccCode { get; set; }
        public string ProgTrackingCode { get; set; }
        public string SiteTrackingCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual XeroInvoice XeroInvoice { get; set; }
    }
}
