using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProgramMedia
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int MediaId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual Media Media { get; set; }
        public virtual Program Program { get; set; }
    }
}
