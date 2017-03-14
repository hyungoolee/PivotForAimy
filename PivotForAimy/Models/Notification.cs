using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Notification
    {
        public Notification()
        {
            NotificationInstance = new HashSet<NotificationInstance>();
            NotificationUser = new HashSet<NotificationUser>();
        }

        public int Id { get; set; }
        public int TypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Role { get; set; }
        public bool? AllowChange { get; set; }

        public virtual ICollection<NotificationInstance> NotificationInstance { get; set; }
        public virtual ICollection<NotificationUser> NotificationUser { get; set; }
        public virtual Lookup Type { get; set; }
    }
}
