using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoiceExtraCharge
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Description { get; set; }
        public decimal ExtraAmount { get; set; }
        public int? ItemCodeId { get; set; }
        public int? TrackingCodeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
