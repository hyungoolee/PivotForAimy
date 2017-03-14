using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ChildContact
    {
        public ChildContact()
        {
            ChildContactMedia = new HashSet<ChildContactMedia>();
        }

        public int Id { get; set; }
        public int? ChildId { get; set; }
        public int? ContactId { get; set; }
        public bool? CanPickup { get; set; }
        public string ActionOnAppear { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string PinCode { get; set; }
        public string Relation { get; set; }
        public bool? IsCyfs { get; set; }
        public string CyfsInformation { get; set; }
        public bool? IsInCustodyArrangement { get; set; }
        public string CustodyArrangemenInformation { get; set; }
        public string OtherRelation { get; set; }
        public string SocialWorkerId { get; set; }

        public virtual ICollection<ChildContactMedia> ChildContactMedia { get; set; }
        public virtual Child Child { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
