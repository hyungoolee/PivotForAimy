using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class DashboardMessage
    {
        public DashboardMessage()
        {
            UserMessage = new HashSet<UserMessage>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int OrgId { get; set; }
        public string MessageType { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<UserMessage> UserMessage { get; set; }
        public virtual Org Org { get; set; }
    }
}
