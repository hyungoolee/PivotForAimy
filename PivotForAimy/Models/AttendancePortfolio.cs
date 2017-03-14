using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AttendancePortfolio
    {
        public int Id { get; set; }
        public int PortfolioSettingId { get; set; }
        public int UserId { get; set; }
        public int AttendanceId { get; set; }
        public int ChildId { get; set; }
        public string Note { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual Attendance Attendance { get; set; }
        public virtual Child Child { get; set; }
        public virtual PortfolioSetting PortfolioSetting { get; set; }
        public virtual User User { get; set; }
    }
}
