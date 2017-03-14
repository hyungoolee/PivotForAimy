using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ActivityItem
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Verson { get; set; }
        public int? ItemType { get; set; }
        public int? InStock { get; set; }
        public string Unit { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Lookup ItemTypeNavigation { get; set; }
    }
}
