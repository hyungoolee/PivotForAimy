using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PortfolioSetting
    {
        public PortfolioSetting()
        {
            AttendancePortfolio = new HashSet<AttendancePortfolio>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<AttendancePortfolio> AttendancePortfolio { get; set; }
        public virtual Org Site { get; set; }
    }
}
