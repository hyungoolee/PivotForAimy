using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SchoolOrg
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int SchoolId { get; set; }
        public string Notes { get; set; }
        public string PickUpLocation { get; set; }
        public bool CanPickUp { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Org Org { get; set; }
        public virtual School School { get; set; }
    }
}
