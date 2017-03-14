using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssBilling
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime BillingStartDate { get; set; }
        public DateTime BillingEndDate { get; set; }
        public string Status { get; set; }
        public DateTime? PaidOn { get; set; }
        public string PaidBy { get; set; }
        public string PaymentStatus { get; set; }
        public bool IsActive { get; set; }
        public string Error { get; set; }

        public virtual CssSubscription Subscription { get; set; }
    }
}
