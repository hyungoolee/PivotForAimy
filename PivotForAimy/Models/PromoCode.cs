using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PromoCode
    {
        public PromoCode()
        {
            Billing = new HashSet<Billing>();
            PromoCodeUsage = new HashSet<PromoCodeUsage>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime? StartOn { get; set; }
        public DateTime? FinishOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool? IsHoliday { get; set; }

        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<PromoCodeUsage> PromoCodeUsage { get; set; }
        public virtual Org Site { get; set; }
        public virtual User User { get; set; }
    }
}
