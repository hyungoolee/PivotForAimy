using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssInvoiceLine1
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Account { get; set; }
        public decimal Amount { get; set; }
        public string TaxRate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
    }
}
