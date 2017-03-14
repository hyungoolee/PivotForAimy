using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ArchivedInvoiceAttendance
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int AttId { get; set; }
        public int BillingId { get; set; }
        public int TermId { get; set; }
        public int SiteId { get; set; }
        public int? RollCallStatus { get; set; }
        public string ChildName { get; set; }
        public string ProgramName { get; set; }
        public DateTime BookedStart { get; set; }
        public DateTime BookedEnd { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public decimal? ActualMin { get; set; }
        public decimal? ChargedMin { get; set; }
        public decimal? OriginalCost { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FinalCost { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
