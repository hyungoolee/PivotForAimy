using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class HeadCountLine
    {
        public int Id { get; set; }
        public int? HeadCountId { get; set; }
        public int? AttendanceId { get; set; }
        public bool IsAccounted { get; set; }
        public string Notes { get; set; }
        public string SiteGroups { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int? ChildId { get; set; }
        public string ChildName { get; set; }
        public string ChildPhoto { get; set; }
        public int? DayIndex { get; set; }

        public virtual Attendance Attendance { get; set; }
        public virtual HeadCount HeadCount { get; set; }
    }
}
