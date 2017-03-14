using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SelectedInvoice
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public int WeekNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }
    }
}
