using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingTypeRule
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? BookingTypeId { get; set; }
        public int? MinDayThreshold { get; set; }
        public int? MaxDayThreshold { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Lookup BookingType { get; set; }
    }
}
