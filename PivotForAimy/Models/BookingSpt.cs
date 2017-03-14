using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingSpt
    {
        public BookingSpt()
        {
            AppliedDiscount = new HashSet<AppliedDiscount>();
            Attendance = new HashSet<Attendance>();
            AttendanceStaging = new HashSet<AttendanceStaging>();
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            InvoiceHistoryLine = new HashSet<InvoiceHistoryLine>();
            InvoiceLine = new HashSet<InvoiceLine>();
            SiteGroupBookingSpt = new HashSet<SiteGroupBookingSpt>();
        }

        public int Id { get; set; }
        public int? BookingId { get; set; }
        public int? SptId { get; set; }
        public int? ItemCodeId { get; set; }
        public int? TrackingCodeId { get; set; }
        public int? SessionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool? WeeklyApplied { get; set; }

        public virtual ICollection<AppliedDiscount> AppliedDiscount { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<AttendanceStaging> AttendanceStaging { get; set; }
        public virtual ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual ICollection<InvoiceHistoryLine> InvoiceHistoryLine { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }
        public virtual ICollection<SiteGroupBookingSpt> SiteGroupBookingSpt { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual XeroItemCode ItemCode { get; set; }
        public virtual Session Session { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
        public virtual XeroTrackingCatOption TrackingCode { get; set; }
    }
}
