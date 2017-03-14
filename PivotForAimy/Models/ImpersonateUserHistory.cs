using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class ImpersonateUserHistory
    {
        public int Id { get; set; }
        public int ImpersonatedUser { get; set; }
        public int ImpersonatedBy { get; set; }
        public DateTime ImpersonatedFrom { get; set; }
        public DateTime ImpersonatedTo { get; set; }

        public virtual User ImpersonatedByNavigation { get; set; }
        public virtual User ImpersonatedUserNavigation { get; set; }
    }
}
