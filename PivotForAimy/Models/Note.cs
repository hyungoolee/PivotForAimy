using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
    }
}
