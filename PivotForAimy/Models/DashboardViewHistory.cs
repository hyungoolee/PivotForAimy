using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class DashboardViewHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProgramCategoryId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual User User { get; set; }
    }
}
