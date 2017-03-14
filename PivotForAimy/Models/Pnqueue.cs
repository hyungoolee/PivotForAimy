using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Pnqueue
    {
        public int Id { get; set; }
        public int NotificationMessageId { get; set; }
        public int UserId { get; set; }
        public string AppName { get; set; }
        public bool IsProcessed { get; set; }
        public int RetryCount { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Pnmessage NotificationMessage { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
