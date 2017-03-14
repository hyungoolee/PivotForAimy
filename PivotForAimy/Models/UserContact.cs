using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserContact
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ContactId { get; set; }
        public int? ContactTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Lookup ContactType { get; set; }
        public virtual User User { get; set; }
    }
}
