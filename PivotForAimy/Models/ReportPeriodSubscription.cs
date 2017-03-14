using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ReportPeriodSubscription
    {
        public int Id { get; set; }
        public int ReportPeriodId { get; set; }
        public int ReportSubscriptionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ReportPeriod ReportPeriod { get; set; }
        public virtual ReportSubscription ReportSubscription { get; set; }
    }
}
