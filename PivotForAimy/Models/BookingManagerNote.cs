using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingManagerNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int BillingId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int UpdatedById { get; set; }
        public bool EditableByOther { get; set; }
        public bool IsActive { get; set; }
        public bool IsLatest { get; set; }

        public virtual Billing Billing { get; set; }
    }
}
