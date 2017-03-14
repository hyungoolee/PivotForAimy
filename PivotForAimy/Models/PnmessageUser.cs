using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PnmessageUser
    {
        public int Id { get; set; }
        public int NotificationMessageId { get; set; }
        public int UserId { get; set; }
        public DateTime? RepliedOn { get; set; }
        public string ResponseMessage { get; set; }
        public string CustomisedResponseMessage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreateBy { get; set; }

        public virtual Pnmessage NotificationMessage { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
