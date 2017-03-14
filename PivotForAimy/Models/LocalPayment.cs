using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class LocalPayment
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int InvoiceId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaidOn { get; set; }
        public string PaymentReference { get; set; }
        public string PaymentType { get; set; }
        public int PaymentMethodId { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int? PaymentId { get; set; }
        public int? CreditNoteId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string PaidBy { get; set; }

        public virtual CreditNote CreditNote { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Lookup PaymentMethod { get; set; }
        public virtual Org Site { get; set; }
    }
}
