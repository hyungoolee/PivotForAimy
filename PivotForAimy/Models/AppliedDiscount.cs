using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AppliedDiscount
    {
        public int Id { get; set; }
        public int BookingSptId { get; set; }
        public int? ChildDiscountId { get; set; }
        public decimal? DiscountedRate { get; set; }
        public decimal TotalAppliedAmount { get; set; }
        public decimal TotalAppliedPercentage { get; set; }
        public string DiscountType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string Description { get; set; }
        public string DiscountLogicType { get; set; }
        public int? RefInvoiceId { get; set; }

        public virtual BookingSpt BookingSpt { get; set; }
        public virtual ChildDiscount ChildDiscount { get; set; }
    }
}
