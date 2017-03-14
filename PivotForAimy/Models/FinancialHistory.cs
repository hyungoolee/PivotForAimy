using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FinancialHistory
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal? TotalIncomeGross { get; set; }
        public decimal? GrossProfit { get; set; }
        public decimal? TotalOperatingExpense { get; set; }
        public decimal? TotalBankBalance { get; set; }
        public decimal? NetProfit { get; set; }
        public DateTime? XeroLastUpdated { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] Version { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Org { get; set; }
    }
}
