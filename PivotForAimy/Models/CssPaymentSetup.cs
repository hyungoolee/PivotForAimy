using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssPaymentSetup
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string MaskedCardNumber { get; set; }
        public string CreditCardType { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool? HasError { get; set; }
        public string Error { get; set; }

        public virtual Org Org { get; set; }
    }
}
