using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MsdjobQueue
    {
        public MsdjobQueue()
        {
            MsdjobConfig = new HashSet<MsdjobConfig>();
        }

        public int Id { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CretaedBy { get; set; }
        public DateTime? ProcessedOn { get; set; }

        public virtual ICollection<MsdjobConfig> MsdjobConfig { get; set; }
    }
}
