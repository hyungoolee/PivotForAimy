using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TimeSheet
    {
        public TimeSheet()
        {
            StaffRoster = new HashSet<StaffRoster>();
        }

        public int Id { get; set; }
        public int StaffId { get; set; }
        public int OrgId { get; set; }
        public string EmployeeId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? BatchId { get; set; }

        public virtual ICollection<StaffRoster> StaffRoster { get; set; }
        public virtual BatchTimeSheets Batch { get; set; }
        public virtual Org Org { get; set; }
        public virtual User Staff { get; set; }
    }
}
