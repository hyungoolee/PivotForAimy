using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PnmessageResponseOption
    {
        public int Id { get; set; }
        public int NotificationMessageId { get; set; }
        public string ResponseOption { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Pnmessage NotificationMessage { get; set; }
    }
}
