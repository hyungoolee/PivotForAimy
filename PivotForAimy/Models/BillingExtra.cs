using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BillingExtra
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public int ItemCodeId { get; set; }
        public int TrackingCatOptId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public string PaymentFrequency { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual XeroItemCode ItemCode { get; set; }
        public virtual XeroTrackingCatOption TrackingCatOpt { get; set; }
    }
}
