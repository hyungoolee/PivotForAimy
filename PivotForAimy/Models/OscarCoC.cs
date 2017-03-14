using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarCoC
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SiteId { get; set; }
        public bool IsRequired { get; set; }
        public bool FormSent { get; set; }
        public bool FormRecieved { get; set; }
        public bool FormLodged { get; set; }
        public bool IsVerified { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeclined { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public DateTime? FormSentDate { get; set; }
        public DateTime? FormReceivedDate { get; set; }
        public DateTime? FormLodgedDate { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public bool? IsNewApplication { get; set; }
        public int? TermId { get; set; }
        public int? TermHolidayId { get; set; }
        public bool IsActive { get; set; }
        public bool? Returned { get; set; }
        public DateTime? ReturnedDate { get; set; }

        public virtual Org Site { get; set; }
        public virtual Term TermHoliday { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
    }
}
