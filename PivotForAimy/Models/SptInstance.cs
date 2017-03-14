using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SptInstance
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public int? StaffId { get; set; }
        public bool? IsFullDay { get; set; }
        public decimal? Cost { get; set; }
        public int? SiteId { get; set; }
        public int? TermId { get; set; }
        public int? Capacity { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int? Duration { get; set; }
        public string RecurrenceType { get; set; }
        public int? RecurrenceId { get; set; }
        public string RecurrenceException { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool IsActive { get; set; }
        public int? SptId { get; set; }

        public virtual Program Class { get; set; }
        public virtual Org Site { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
        public virtual Term Term { get; set; }
    }
}
