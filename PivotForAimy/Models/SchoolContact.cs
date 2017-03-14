using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class SchoolContact
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public int ContactId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual School School { get; set; }
    }
}
