using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserDiscount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrgId { get; set; }
        public decimal? FirstChildDiscount { get; set; }
        public decimal? SecondChildDiscount { get; set; }
        public decimal? ThirdChildDiscount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual Org Org { get; set; }
        public virtual User User { get; set; }
    }
}
