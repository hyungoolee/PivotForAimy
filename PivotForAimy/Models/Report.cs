using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportPeriod = new HashSet<ReportPeriod>();
        }

        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ReportPeriod> ReportPeriod { get; set; }
        public virtual Org Site { get; set; }
    }
}
