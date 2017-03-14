using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroInvoice
    {
        public XeroInvoice()
        {
            Payment = new HashSet<Payment>();
            XeroInvoiceLine = new HashSet<XeroInvoiceLine>();
            XeroPayment = new HashSet<XeroPayment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int StatusId { get; set; }
        public string XeroConsumerKey { get; set; }
        public Guid XeroInvoiceId { get; set; }
        public string XeroInvoiceCode { get; set; }
        public string Email { get; set; }
        public string Reference { get; set; }
        public decimal? Discount { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? AmountCredited { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? Error { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<XeroInvoiceLine> XeroInvoiceLine { get; set; }
        public virtual ICollection<XeroPayment> XeroPayment { get; set; }
        public virtual XeroLookup Status { get; set; }
        public virtual User User { get; set; }
    }
}
