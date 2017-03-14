using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CreditNoteLineItem
    {
        public int Id { get; set; }
        public int CreditNoteId { get; set; }
        public int? OriginalInvoiceId { get; set; }
        public int? BookingSptId { get; set; }
        public string Description { get; set; }
        public decimal AppliedAmount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? XeroItemCodeId { get; set; }
        public int? XeroTrackingCodeId { get; set; }

        public virtual BookingSpt BookingSpt { get; set; }
        public virtual CreditNote CreditNote { get; set; }
        public virtual Invoice OriginalInvoice { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
        public virtual XeroTrackingCatOption XeroTrackingCode { get; set; }
    }
}
