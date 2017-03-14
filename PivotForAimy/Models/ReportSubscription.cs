using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ReportSubscription
    {
        public ReportSubscription()
        {
            ReportPeriodSubscription = new HashSet<ReportPeriodSubscription>();
            ReportSubscriber = new HashSet<ReportSubscriber>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportPeriodId { get; set; }
        public int SiteId { get; set; }
        public DateTime? NextDeliveredOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ReportPeriodSubscription> ReportPeriodSubscription { get; set; }
        public virtual ICollection<ReportSubscriber> ReportSubscriber { get; set; }
        public virtual Org Site { get; set; }
    }
}
