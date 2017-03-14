using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgGroup
    {
        public OrgGroup()
        {
            ChildOrgGroup = new HashSet<ChildOrgGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int? TermId { get; set; }
        public int? SiteId { get; set; }
        public int? SptId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int? ProgramCategoryId { get; set; }
        public int? SessionId { get; set; }

        public virtual ICollection<ChildOrgGroup> ChildOrgGroup { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
        public virtual Session Session { get; set; }
        public virtual Org Site { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
        public virtual Term Term { get; set; }
    }
}
