using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingSpt = new HashSet<BookingSpt>();
            ChildDiscountHistoryLookup = new HashSet<ChildDiscountHistoryLookup>();
            WaitingList = new HashSet<WaitingList>();
        }

        public int Id { get; set; }
        public int BillingId { get; set; }
        public int? ItemCodeId { get; set; }
        public int GuardianId { get; set; }
        public int ProgramCategoryId { get; set; }
        public int SiteId { get; set; }
        public int ChildId { get; set; }
        public int? TrackingCatOptId { get; set; }
        public int? BookingTypeId { get; set; }
        public string Status { get; set; }
        public DateTime? WhenBooked { get; set; }
        public string Comment { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<BookingSpt> BookingSpt { get; set; }
        public virtual ICollection<ChildDiscountHistoryLookup> ChildDiscountHistoryLookup { get; set; }
        public virtual ICollection<WaitingList> WaitingList { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual Lookup BookingType { get; set; }
        public virtual Child Child { get; set; }
        public virtual User Guardian { get; set; }
        public virtual XeroItemCode ItemCode { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual Org Site { get; set; }
        public virtual XeroTrackingCatOption TrackingCatOpt { get; set; }
    }
}
