using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PaymentSource
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int InvoiceId { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreaetedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
