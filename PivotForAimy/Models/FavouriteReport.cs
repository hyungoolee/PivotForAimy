using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class FavouriteReport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Site { get; set; }
        public virtual User User { get; set; }
    }
}
