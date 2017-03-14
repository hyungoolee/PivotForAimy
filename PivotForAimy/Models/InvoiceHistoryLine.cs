using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoiceHistoryLine
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? BookingSptId { get; set; }
        public int? ItemCodeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? TrackingCodeId { get; set; }

        public virtual BookingSpt BookingSpt { get; set; }
        public virtual InvoiceHistory Invoice { get; set; }
        public virtual XeroItemCode ItemCode { get; set; }
        public virtual XeroTrackingCatOption TrackingCode { get; set; }
    }
}
