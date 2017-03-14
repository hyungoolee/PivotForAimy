using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BatchTimeSheets
    {
        public BatchTimeSheets()
        {
            TimeSheet = new HashSet<TimeSheet>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public int NumberOfRecords { get; set; }
        public DateTime ProcessedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
        public virtual Org Org { get; set; }
    }
}
