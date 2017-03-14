using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SptExcludeDays
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public DateTime ExcludeDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual SiteProgramTerm Spt { get; set; }
    }
}
