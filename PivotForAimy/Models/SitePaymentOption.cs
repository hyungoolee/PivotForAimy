using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SitePaymentOption
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int PaymentOptionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Lookup PaymentOption { get; set; }
    }
}
