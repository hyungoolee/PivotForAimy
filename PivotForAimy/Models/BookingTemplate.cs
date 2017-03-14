using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingTemplate
    {
        public BookingTemplate()
        {
            Billing = new HashSet<Billing>();
            BookingTemplateQueue = new HashSet<BookingTemplateQueue>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public string Term { get; set; }
        public bool? IsDisplayPrice { get; set; }
        public string ImageUrl { get; set; }
        public int? Index { get; set; }
        public int? SptInstanceId { get; set; }

        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<BookingTemplateQueue> BookingTemplateQueue { get; set; }
        public virtual Org Site { get; set; }
    }
}
