using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SiteNotes
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? ProgramCategoryId { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual Org Site { get; set; }
    }
}
