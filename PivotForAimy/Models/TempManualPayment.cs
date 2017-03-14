using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TempManualPayment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amout { get; set; }
        public int InvoiceId { get; set; }
        public string ParentName { get; set; }
        public string OrgName { get; set; }
        public int? ParentId { get; set; }
        public int? OrgId { get; set; }
    }
}
