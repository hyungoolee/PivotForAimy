using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class NoteLookup
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
