using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MediaExtension
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public string Category { get; set; }
        public string Caption { get; set; }
        public string FormatType { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Tag { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Media Media { get; set; }
        public virtual User User { get; set; }
    }
}
