using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SubsidyPaymentIndex
    {
        public SubsidyPaymentIndex()
        {
            SubsidyPayment = new HashSet<SubsidyPayment>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
    }
}
