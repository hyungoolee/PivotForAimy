using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AimyTermsAndConditions
    {
        public AimyTermsAndConditions()
        {
            AimyAcceptedTermsAndConditions = new HashSet<AimyAcceptedTermsAndConditions>();
        }

        public int Id { get; set; }
        public string TermsAndConditions { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDraft { get; set; }

        public virtual ICollection<AimyAcceptedTermsAndConditions> AimyAcceptedTermsAndConditions { get; set; }
    }
}
