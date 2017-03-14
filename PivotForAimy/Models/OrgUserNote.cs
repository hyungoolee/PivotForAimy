using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgUserNote
    {
        public int Id { get; set; }
        public int OrgUserId { get; set; }
        public string Notes { get; set; }
        public DateTime? NoteDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual OrgUser OrgUser { get; set; }
    }
}
