using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class DailyAttendance
    {
        public int Id { get; set; }
        public int? SptId { get; set; }
        public DateTime Date { get; set; }
        public int? TotalBooking { get; set; }
        public int? TotalAttended { get; set; }
        public int? TotalMsdattended { get; set; }
        public int? TotalAbsence { get; set; }
        public int? TotalCasual { get; set; }
        public int? SiteId { get; set; }
        public int? ProgramCategoryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int? HoTermId { get; set; }
    }
}
