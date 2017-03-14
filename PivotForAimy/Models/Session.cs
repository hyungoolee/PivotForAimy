using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Session
    {
        public Session()
        {
            Attendance = new HashSet<Attendance>();
            AttendanceStaging = new HashSet<AttendanceStaging>();
            BookingSpt = new HashSet<BookingSpt>();
            OrgGroup = new HashSet<OrgGroup>();
            Program = new HashSet<Program>();
            ProgramSession = new HashSet<ProgramSession>();
            SessionDiscount = new HashSet<SessionDiscount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public decimal? Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int? XeroItemCodeId { get; set; }
        public int? Index { get; set; }
        public bool? CanApplyWeeklyRate { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStaging { get; set; }
        public virtual ICollection<BookingSpt> BookingSpt { get; set; }
        public virtual ICollection<OrgGroup> OrgGroup { get; set; }
        public virtual ICollection<Program> Program { get; set; }
        public virtual ICollection<ProgramSession> ProgramSession { get; set; }
        public virtual ICollection<SessionDiscount> SessionDiscount { get; set; }
        public virtual Org Site { get; set; }
        public virtual XeroItemCode XeroItemCode { get; set; }
    }
}
