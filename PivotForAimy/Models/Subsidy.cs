using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Subsidy
    {
        public Subsidy()
        {
            SubsidyPayment = new HashSet<SubsidyPayment>();
        }

        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? ParentId { get; set; }
        public int? ChildId { get; set; }
        public string ClientNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsWeeklyPayment { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? Hour { get; set; }
        public decimal? Amount { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual Child Child { get; set; }
        public virtual User Parent { get; set; }
    }
}
