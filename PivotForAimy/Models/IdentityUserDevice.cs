using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class IdentityUserDevice
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeviceId { get; set; }
        public string RefreshToken { get; set; }
        public int DevicePlatform { get; set; }
        public string DeviceOsVersion { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceManufacturer { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public string NotificationId { get; set; }
        public string NotificationPlatform { get; set; }
        public string NotificationTag { get; set; }
        public string AppVersion { get; set; }
        public string LatestIpAddress { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
