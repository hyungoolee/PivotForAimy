using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingTemplateQueueChild
    {
        public int Id { get; set; }
        public int BookingTemplateQueueId { get; set; }
        public int ChildId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual BookingTemplateQueue BookingTemplateQueue { get; set; }
        public virtual Child Child { get; set; }
    }
}
