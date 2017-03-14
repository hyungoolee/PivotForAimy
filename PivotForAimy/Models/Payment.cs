using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Payment
    {
        public Payment()
        {
            LocalPayment = new HashSet<LocalPayment>();
            XeroPaymentQueue = new HashSet<XeroPaymentQueue>();
        }

        public int Id { get; set; }
        public int PaymentBatchId { get; set; }
        public int? SiteId { get; set; }
        public int? InvoiceId { get; set; }
        public int? XeroInvoiceId { get; set; }
        public int XeroStatusId { get; set; }
        public int? BillingId { get; set; }
        public Guid? XeroTransactionId { get; set; }
        public decimal PaidAmount { get; set; }
        public bool Error { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime? XeroLastUpdatedUtc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool? IsConfirmed { get; set; }

        public virtual ICollection<LocalPayment> LocalPayment { get; set; }
        public virtual ICollection<XeroPaymentQueue> XeroPaymentQueue { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual PaymentBatch PaymentBatch { get; set; }
        public virtual XeroInvoice XeroInvoice { get; set; }
        public virtual Lookup XeroStatus { get; set; }
    }
}
