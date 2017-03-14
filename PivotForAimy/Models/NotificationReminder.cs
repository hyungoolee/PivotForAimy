using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class NotificationReminder
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public int ModuleId { get; set; }
        public bool? FirstProcessed { get; set; }
        public bool? SecondProcessed { get; set; }
        public bool? ThirdProcessed { get; set; }
        public int DeliveryRule { get; set; }
        public DateTime? LastProcessedOn { get; set; }
        public int SiteId { get; set; }
        public string Error { get; set; }
        public int? RetryCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Source { get; set; }
        public string Reference { get; set; }
        public bool? IsActive { get; set; }

        public virtual Org Site { get; set; }
    }
}
