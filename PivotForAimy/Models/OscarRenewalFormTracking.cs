using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarRenewalFormTracking
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SiteId { get; set; }
        public DateTime? CurrentReviewDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public bool Stage1 { get; set; }
        public DateTime? Stage1Date { get; set; }
        public bool Stage2 { get; set; }
        public DateTime? Stage2Date { get; set; }
        public bool Stage3 { get; set; }
        public DateTime? Stage3Date { get; set; }
        public bool Stage4 { get; set; }
        public DateTime? Stage4Date { get; set; }
        public bool Submitted { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsCompleted { get; set; }
        public bool? IsDeclined { get; set; }
        public bool? IsNewApplication { get; set; }
        public int? TermId { get; set; }
        public int? TermHolidayId { get; set; }
        public bool? Received { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public bool? Returned { get; set; }
        public DateTime? ReturnedDate { get; set; }

        public virtual Term TermHoliday { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
    }
}
