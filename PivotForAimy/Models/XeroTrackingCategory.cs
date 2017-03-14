using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroTrackingCategory
    {
        public XeroTrackingCategory()
        {
            XeroTrackingCatOption = new HashSet<XeroTrackingCatOption>();
        }

        public int Id { get; set; }
        public Guid XeroTrackingCatId { get; set; }
        public int SiteId { get; set; }
        public string TrackingName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<XeroTrackingCatOption> XeroTrackingCatOption { get; set; }
        public virtual Org Site { get; set; }
    }
}
