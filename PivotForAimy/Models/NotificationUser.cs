using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class NotificationUser
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Devices { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public string Smsnumber { get; set; }
        public string EmailAddress { get; set; }
        public bool? IsDashboard { get; set; }
        public string ToValue { get; set; }

        public virtual Notification Notification { get; set; }
        public virtual User User { get; set; }
    }
}
