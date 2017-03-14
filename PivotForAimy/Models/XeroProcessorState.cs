using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroProcessorState
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsProcessed { get; set; }
        public string EntityType { get; set; }
        public string XeroConsumerKey { get; set; }
        public bool? Error { get; set; }
        public string ErrorDescription { get; set; }

        public virtual Org Org { get; set; }
    }
}
