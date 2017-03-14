using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class DefaultBillingDiscount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BillingId { get; set; }
        public string DiscountType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual User User { get; set; }
    }
}
