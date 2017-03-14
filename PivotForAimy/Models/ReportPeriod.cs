using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ReportPeriod
    {
        public ReportPeriod()
        {
            ReportPeriodSubscription = new HashSet<ReportPeriodSubscription>();
        }

        public int Id { get; set; }
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ReportPeriodSubscription> ReportPeriodSubscription { get; set; }
        public virtual Report Report { get; set; }
    }
}
