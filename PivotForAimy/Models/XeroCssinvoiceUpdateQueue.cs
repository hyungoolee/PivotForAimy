using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroCssinvoiceUpdateQueue
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceItemId { get; set; }
        public bool IsProcessed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
