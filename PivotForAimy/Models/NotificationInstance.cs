using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class NotificationInstance
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public int OrgId { get; set; }
        public int? UserId { get; set; }
        public string Subject { get; set; }
        public int ModuleId { get; set; }
        public string Message { get; set; }
        public string Attachment { get; set; }
        public string Error { get; set; }
        public int? RetryCount { get; set; }
        public bool? EmailProcessed { get; set; }
        public bool? Smsprocessed { get; set; }
        public string Source { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsProcessed { get; set; }

        public virtual Notification Notification { get; set; }
        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
