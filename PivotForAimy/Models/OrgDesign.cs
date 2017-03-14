using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgDesign
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? LogoTypeId { get; set; }
        public string Logo { get; set; }
        public string Colour { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual Lookup LogoType { get; set; }
        public virtual Org Site { get; set; }
    }
}
