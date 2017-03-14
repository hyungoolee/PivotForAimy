using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class InvoiceSettingAudit
    {
        public int Id { get; set; }
        public string LastChangeDescription { get; set; }
        public string CurrentDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
    }
}
