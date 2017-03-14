using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserOrgAccess
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrgId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
