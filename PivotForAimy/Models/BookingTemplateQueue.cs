using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingTemplateQueue
    {
        public BookingTemplateQueue()
        {
            Billing = new HashSet<Billing>();
            BookingTemplateQueueChild = new HashSet<BookingTemplateQueueChild>();
        }

        public int Id { get; set; }
        public int BookingTemplateId { get; set; }
        public int UserId { get; set; }
        public int PaymentOptionId { get; set; }
        public bool? IncludePastBookings { get; set; }
        public bool? OscarIntended { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string Error { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ParentNotes { get; set; }

        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<BookingTemplateQueueChild> BookingTemplateQueueChild { get; set; }
        public virtual BookingTemplate BookingTemplate { get; set; }
        public virtual Lookup PaymentOption { get; set; }
        public virtual User User { get; set; }
    }
}
