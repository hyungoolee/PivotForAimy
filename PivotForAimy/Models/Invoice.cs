using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            BatchConfirmedInvoice = new HashSet<BatchConfirmedInvoice>();
            CreditNoteAllocatedInvoice = new HashSet<CreditNoteAllocatedInvoice>();
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            DeletingInvoiceQueue = new HashSet<DeletingInvoiceQueue>();
            InvoiceExtraCharge = new HashSet<InvoiceExtraCharge>();
            InvoiceLine = new HashSet<InvoiceLine>();
            InvoicePayment = new HashSet<InvoicePayment>();
            LocalPayment = new HashSet<LocalPayment>();
            Payment = new HashSet<Payment>();
            PaymentSource = new HashSet<PaymentSource>();
            SubsidyPayment = new HashSet<SubsidyPayment>();
            XeroEditInvoiceQueue = new HashSet<XeroEditInvoiceQueue>();
            XeroInvoiceQueue = new HashSet<XeroInvoiceQueue>();
        }

        public int Id { get; set; }
        public int BillingId { get; set; }
        public int StatusId { get; set; }
        public Guid? XeroInvoiceId { get; set; }
        public string XeroInvoiceCode { get; set; }
        public string Reference { get; set; }
        public string Email { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountReason { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? AmountCredited { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public bool Error { get; set; }
        public string ErrorDescription { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? OriginalTotalAmount { get; set; }
        public DateTime? XeroUpdatedDateUtc { get; set; }
        public string InvoiceType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string EmailStatus { get; set; }
        public string EmailToken { get; set; }
        public DateTime? LastAttDate { get; set; }
        public DateTime? FirstAttDate { get; set; }
        public DateTime? InvoiceDate { get; set; }

        public virtual ICollection<BatchConfirmedInvoice> BatchConfirmedInvoice { get; set; }
        public virtual ICollection<CreditNoteAllocatedInvoice> CreditNoteAllocatedInvoice { get; set; }
        public virtual ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual ICollection<DeletingInvoiceQueue> DeletingInvoiceQueue { get; set; }
        public virtual ICollection<InvoiceExtraCharge> InvoiceExtraCharge { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }
        public virtual ICollection<InvoicePayment> InvoicePayment { get; set; }
        public virtual ICollection<LocalPayment> LocalPayment { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<PaymentSource> PaymentSource { get; set; }
        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual ICollection<XeroEditInvoiceQueue> XeroEditInvoiceQueue { get; set; }
        public virtual ICollection<XeroInvoiceQueue> XeroInvoiceQueue { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual Lookup Status { get; set; }
    }
}
