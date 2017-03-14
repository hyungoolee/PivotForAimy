using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgTermsConditions
    {
        public OrgTermsConditions()
        {
            OrgAcceptedTermsAndConditions = new HashSet<OrgAcceptedTermsAndConditions>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public string TermConditions { get; set; }
        public string LogoUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDraft { get; set; }

        public virtual ICollection<OrgAcceptedTermsAndConditions> OrgAcceptedTermsAndConditions { get; set; }
        public virtual Org Org { get; set; }
    }
}
