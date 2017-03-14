using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgNotificationSetting
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int NotificationType { get; set; }
        public bool IsActive { get; set; }
        public bool AllowNotification { get; set; }
        public int? FirstDeliveryRule { get; set; }
        public int? SecondDeliveryRule { get; set; }
        public int? ThirdDeliveryRule { get; set; }

        public virtual Lookup NotificationTypeNavigation { get; set; }
        public virtual Org Org { get; set; }
    }
}
