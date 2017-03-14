using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class DatabaseChangeHistory
    {
        public int Id { get; set; }
        public string SqlfileName { get; set; }
        public DateTime ExecutedOn { get; set; }
        public string Developer { get; set; }
    }
}
