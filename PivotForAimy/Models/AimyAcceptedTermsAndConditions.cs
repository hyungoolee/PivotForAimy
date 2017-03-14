using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class AimyAcceptedTermsAndConditions
    {
        public int Id { get; set; }
        public string EntityType { get; set; }
        public int? EntityId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int TandCid { get; set; }
        public bool IsActive { get; set; }

        public virtual AimyTermsAndConditions TandC { get; set; }
    }
}
