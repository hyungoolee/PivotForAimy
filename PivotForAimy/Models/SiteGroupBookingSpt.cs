using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SiteGroupBookingSpt
    {
        public int Id { get; set; }
        public int SiteGroupId { get; set; }
        public int BookingSptId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual BookingSpt BookingSpt { get; set; }
        public virtual SiteGroup SiteGroup { get; set; }
    }
}
