using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MsdjobConfig
    {
        public int Id { get; set; }
        public int MsdjobId { get; set; }
        public int SiteId { get; set; }
        public int TermId { get; set; }

        public virtual MsdjobQueue Msdjob { get; set; }
    }
}
