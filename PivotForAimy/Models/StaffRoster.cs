using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class StaffRoster
    {
        public StaffRoster()
        {
            ActivityInstanceStaff = new HashSet<ActivityInstanceStaff>();
            StaffClockSignature = new HashSet<StaffClockSignature>();
            StaffRosterHistory = new HashSet<StaffRosterHistory>();
        }

        public int Id { get; set; }
        public int StaffId { get; set; }
        public int OrgId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool? IsSingle { get; set; }
        public int? ParentId { get; set; }
        public decimal? SalaryCost { get; set; }
        public bool HasAttended { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LocalCreatedOn { get; set; }
        public DateTime? LocalUpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }
        public string ClockInMethod { get; set; }
        public string ClockOutMethod { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
        public bool IsProcessed { get; set; }
        public int? TimeSheetId { get; set; }
        public bool IsClockInOutPaid { get; set; }

        public virtual ICollection<ActivityInstanceStaff> ActivityInstanceStaff { get; set; }
        public virtual ICollection<StaffClockSignature> StaffClockSignature { get; set; }
        public virtual ICollection<StaffRosterHistory> StaffRosterHistory { get; set; }
        public virtual Org Org { get; set; }
        public virtual StaffRoster Parent { get; set; }
        public virtual ICollection<StaffRoster> InverseParent { get; set; }
        public virtual User Staff { get; set; }
        public virtual TimeSheet TimeSheet { get; set; }
    }
}
