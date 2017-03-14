using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssInvoice
    {
        public CssInvoice()
        {
            CssInvoiceLine = new HashSet<CssInvoiceLine>();
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public int OrgId { get; set; }
        public Guid? XeroInvoiceId { get; set; }
        public string XeroInvoiceCode { get; set; }
        public string Reference { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountReason { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal? AmountDue { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public bool? Error { get; set; }
        public string ErrorDescription { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? XeroUpdatedDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<CssInvoiceLine> CssInvoiceLine { get; set; }
        public virtual Org Org { get; set; }
    }
}
