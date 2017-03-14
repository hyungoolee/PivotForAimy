using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgStandardDiscount
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int ProgramCategoryId { get; set; }
        public int? BookingTypeId { get; set; }
        public string TypeOfHours { get; set; }
        public decimal? Hours { get; set; }
        public decimal? FirstChildDiscount { get; set; }
        public decimal? SecondChildDiscount { get; set; }
        public decimal? ThirdChildDiscount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual Lookup BookingType { get; set; }
        public virtual Org Org { get; set; }
        public virtual ProgramCategory ProgramCategory { get; set; }
    }
}
