using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ContactGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int OrgId { get; set; }
        public int UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
