using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ProfileNoteSite
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public int SiteId { get; set; }
        public bool IsActive { get; set; }
        public bool IsLatest { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ProfileNote Note { get; set; }
        public virtual Org Site { get; set; }
    }
}
