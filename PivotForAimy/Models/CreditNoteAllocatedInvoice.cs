using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CreditNoteAllocatedInvoice
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int CreditNoteId { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal AppliedAmount { get; set; }
        public DateTime AppliedDate { get; set; }

        public virtual CreditNote CreditNote { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
