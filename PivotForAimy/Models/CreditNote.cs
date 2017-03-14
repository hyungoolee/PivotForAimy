using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CreditNote
    {
        public CreditNote()
        {
            CreditNoteAllocatedInvoice = new HashSet<CreditNoteAllocatedInvoice>();
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            LocalPayment = new HashSet<LocalPayment>();
            XeroCreditNoteQueue = new HashSet<XeroCreditNoteQueue>();
        }

        public int Id { get; set; }
        public int? BillingId { get; set; }
        public Guid? XeroTransactionId { get; set; }
        public int StatusId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string ErrorDescription { get; set; }
        public bool Error { get; set; }
        public string Email { get; set; }
        public DateTime? XeroUpdatedDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string ExternalCreditNoteNumber { get; set; }
        public DateTime? CreditNoteDate { get; set; }

        public virtual ICollection<CreditNoteAllocatedInvoice> CreditNoteAllocatedInvoice { get; set; }
        public virtual ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual ICollection<LocalPayment> LocalPayment { get; set; }
        public virtual ICollection<XeroCreditNoteQueue> XeroCreditNoteQueue { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual Lookup Status { get; set; }
    }
}
