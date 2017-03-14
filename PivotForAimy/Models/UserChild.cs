using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserChild
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ChildId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Child Child { get; set; }
        public virtual User User { get; set; }
    }
}
