using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PromoCodeUsage
    {
        public int Id { get; set; }
        public int? PromoCodeId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateUsed { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual PromoCode PromoCode { get; set; }
        public virtual User User { get; set; }
    }
}
