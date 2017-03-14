using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MessageId { get; set; }
        public bool IsRead { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual DashboardMessage Message { get; set; }
        public virtual User User { get; set; }
    }
}
