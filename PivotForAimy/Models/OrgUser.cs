using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgUser
    {
        public OrgUser()
        {
            OrgUserNote = new HashSet<OrgUserNote>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsInSubsidy { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Notes { get; set; }
        public bool? IsBlackListed { get; set; }
        public bool? HasMissingSignature { get; set; }
        public bool? IsEziDebitSetup { get; set; }

        public virtual ICollection<OrgUserNote> OrgUserNote { get; set; }
        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
