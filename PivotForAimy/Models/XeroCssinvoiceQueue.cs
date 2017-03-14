using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroCssinvoiceQueue
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int InvoiceId { get; set; }
        public bool IsProcessed { get; set; }
        public bool Error { get; set; }
        public string ErrorDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? GenerateInvOn { get; set; }
    }
}
