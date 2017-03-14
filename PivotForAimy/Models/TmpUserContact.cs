using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TmpUserContact
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ContactId { get; set; }
        public int? ContactTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
