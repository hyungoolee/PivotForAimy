using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarTracking
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public bool Intention { get; set; }
        public DateTime? IntendedDate { get; set; }
        public bool FormSent { get; set; }
        public DateTime? FormSentDate { get; set; }
        public bool FormRecieved { get; set; }
        public DateTime? FormRecievedDate { get; set; }
        public bool FormLodged { get; set; }
        public DateTime? FormLodgedDate { get; set; }
        public bool OscarApproved { get; set; }
        public DateTime? OscarApprovedDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string Email { get; set; }
        public bool IsCompleted { get; set; }
        public bool? IsDeclined { get; set; }
        public bool? Term1 { get; set; }
        public bool? Term1Holiday { get; set; }
        public bool? Term2 { get; set; }
        public bool? Term2Holiday { get; set; }
        public bool? Term3 { get; set; }
        public bool? Term3Holiday { get; set; }
        public bool? Term4 { get; set; }
        public bool? Term4Holiday { get; set; }
        public int? ChildId1 { get; set; }
        public int? ChildId2 { get; set; }
        public int? ChildId3 { get; set; }
        public int? ChildId4 { get; set; }
        public int? ChildId5 { get; set; }
        public int? ChildId6 { get; set; }
        public int? SiteId { get; set; }
        public string IntendedNote { get; set; }
        public string IntendedNoteBy { get; set; }
        public string FormSentNote { get; set; }
        public string FormSentNoteBy { get; set; }
        public string FormReceivedNote { get; set; }
        public string FormReceivedNoteBy { get; set; }
        public string FormLodgeNote { get; set; }
        public string FormLodgeNoteBy { get; set; }
        public string OscarApprovedNote { get; set; }
        public string OscarApproveNoteBy { get; set; }
        public bool? IsNewApplication { get; set; }
        public int? TermId { get; set; }
        public int? TermHolidayId { get; set; }
        public bool IsActive { get; set; }
        public bool? ReturnedToParent { get; set; }
        public DateTime? ReturnedToParentDate { get; set; }
        public string ReturnedToParentNote { get; set; }
        public string ReturnedToParentBy { get; set; }

        public virtual Org Site { get; set; }
        public virtual Term TermHoliday { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
    }
}
