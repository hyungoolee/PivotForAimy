using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgAcceptedTermsAndConditions
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int OrgTandCid { get; set; }
        public bool IsActive { get; set; }

        public virtual OrgTermsConditions OrgTandC { get; set; }
        public virtual User Parent { get; set; }
    }
}
