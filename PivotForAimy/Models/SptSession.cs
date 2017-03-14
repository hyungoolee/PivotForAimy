using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SptSession
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public decimal? Rate { get; set; }
        public int? ItemCode { get; set; }
        public bool IsActive { get; set; }

        public virtual SiteProgramTerm Spt { get; set; }
    }
}
