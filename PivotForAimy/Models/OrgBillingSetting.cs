using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgBillingSetting
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int ProgramCategoryId { get; set; }
        public bool IsBasedOnAttendance { get; set; }
        public int? GracePeriod { get; set; }
        public int? MinimumMinBlock { get; set; }
        public string MinimumChargeType { get; set; }
        public decimal? MinimumFlatRate { get; set; }
        public string EarlyPickupType { get; set; }
        public int? EarlyPickupMinBlock { get; set; }
        public decimal? EarlyPickupFlatRate { get; set; }
        public string EarlyDropOffType { get; set; }
        public string EarlyDropoffBasedOn { get; set; }
        public int? EarlyDropOffMinBlock { get; set; }
        public decimal? EarlyDropOffFlatRate { get; set; }
        public string LatePickupType { get; set; }
        public string LatePickupBasedOn { get; set; }
        public int? LatePickupMinBlock { get; set; }
        public decimal? LatePickupFlatRate { get; set; }
        public string NonAttendanceType { get; set; }
        public int? NonAttendanceMinBlock { get; set; }
        public decimal? NonAttendanceValue { get; set; }
        public TimeSpan? SiteEndTime { get; set; }
        public TimeSpan? SiteOpenTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool? ForExpressBooking { get; set; }
        public int? SignInGracePeriod { get; set; }
        public int? SignOutGracePeriod { get; set; }
        public int? NormalMinBlock { get; set; }

        public virtual Org Org { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
    }
}
