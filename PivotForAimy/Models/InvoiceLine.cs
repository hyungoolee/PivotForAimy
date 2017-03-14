using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoiceLine
    {
        public InvoiceLine()
        {
            ChildDiscountHistoryLookup = new HashSet<ChildDiscountHistoryLookup>();
        }

        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? BookingSptId { get; set; }
        public int? ItemCodeId { get; set; }
        public int? TrackingCatOptionId { get; set; }
        public Guid? XeroLineItemId { get; set; }
        public int? AdditionalInvRefId { get; set; }
        public string InvoiceLineType { get; set; }

        public virtual ICollection<ChildDiscountHistoryLookup> ChildDiscountHistoryLookup { get; set; }
        public virtual BookingSpt BookingSpt { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual XeroItemCode ItemCode { get; set; }
        public virtual XeroTrackingCatOption TrackingCatOption { get; set; }
    }
}
