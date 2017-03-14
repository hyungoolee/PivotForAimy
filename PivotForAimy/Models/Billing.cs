using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Billing
    {
        public Billing()
        {
            BatchConfirmedInvoice = new HashSet<BatchConfirmedInvoice>();
            BillingDiscount = new HashSet<BillingDiscount>();
            BillingExtra = new HashSet<BillingExtra>();
            Booking = new HashSet<Booking>();
            BookingAudit = new HashSet<BookingAudit>();
            BookingManagerNote = new HashSet<BookingManagerNote>();
            ChildDiscountHistoryLookup = new HashSet<ChildDiscountHistoryLookup>();
            CreditNote = new HashSet<CreditNote>();
            DefaultBillingDiscount = new HashSet<DefaultBillingDiscount>();
            Invoice = new HashSet<Invoice>();
            InvoiceHistory = new HashSet<InvoiceHistory>();
            Payment = new HashSet<Payment>();
            XeroEditBookingQueue = new HashSet<XeroEditBookingQueue>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public int? PromoCodeId { get; set; }
        public int? PaymentOptionId { get; set; }
        public int? TermId { get; set; }
        public string Description { get; set; }
        public decimal? OriginalCost { get; set; }
        public decimal? EstimatedCost { get; set; }
        public decimal? FinalCost { get; set; }
        public decimal? EstimatedOscar { get; set; }
        public bool? HasSentToXero { get; set; }
        public decimal? PromoAmount { get; set; }
        public decimal? PromoPercentage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string Name { get; set; }
        public int? BookingTemplateId { get; set; }
        public decimal? TotalExtraInvLineAmount { get; set; }
        public string ExtraLineType { get; set; }
        public string ParentNotes { get; set; }
        public bool? OscarIntended { get; set; }
        public bool? IsMadeFromTemplate { get; set; }
        public bool? IsQuickBooked { get; set; }
        public bool? RollOverIntended { get; set; }
        public bool? IsRollOvered { get; set; }
        public bool? IsInvFreqChanged { get; set; }
        public int? ByTemplateQueueId { get; set; }
        public bool? IsChargeByAttendance { get; set; }

        public virtual ICollection<BatchConfirmedInvoice> BatchConfirmedInvoice { get; set; }
        public virtual ICollection<BillingDiscount> BillingDiscount { get; set; }
        public virtual ICollection<BillingExtra> BillingExtra { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<BookingAudit> BookingAudit { get; set; }
        public virtual ICollection<BookingManagerNote> BookingManagerNote { get; set; }
        public virtual ICollection<ChildDiscountHistoryLookup> ChildDiscountHistoryLookup { get; set; }
        public virtual ICollection<CreditNote> CreditNote { get; set; }
        public virtual ICollection<DefaultBillingDiscount> DefaultBillingDiscount { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<InvoiceHistory> InvoiceHistory { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<XeroEditBookingQueue> XeroEditBookingQueue { get; set; }
        public virtual BookingTemplate BookingTemplate { get; set; }
        public virtual BookingTemplateQueue ByTemplateQueue { get; set; }
        public virtual Lookup PaymentOption { get; set; }
        public virtual PromoCode PromoCode { get; set; }
        public virtual Org Site { get; set; }
        public virtual Term Term { get; set; }
        public virtual User User { get; set; }
    }
}
