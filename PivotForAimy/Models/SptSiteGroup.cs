using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SptSiteGroup
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public int SiteGroupId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual SiteGroup SiteGroup { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
    }
}
