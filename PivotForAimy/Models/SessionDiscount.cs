using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SessionDiscount
    {
        public int Id { get; set; }
        public int ChildDiscountId { get; set; }
        public int SessionId { get; set; }
        public decimal DiscountedRate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ChildDiscount ChildDiscount { get; set; }
        public virtual Session Session { get; set; }
    }
}
