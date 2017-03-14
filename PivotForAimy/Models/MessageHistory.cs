using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MessageHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Recipients { get; set; }
        public string DeliveryMethod { get; set; }
        public string Subject { get; set; }
        public string Data { get; set; }
        public DateTime DateSent { get; set; }
        public bool IsActive { get; set; }
        public int? SiteId { get; set; }

        public virtual Org Site { get; set; }
        public virtual User User { get; set; }
    }
}
