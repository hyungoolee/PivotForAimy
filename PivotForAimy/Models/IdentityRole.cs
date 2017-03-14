using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class IdentityRole
    {
        public IdentityRole()
        {
            IdentityUserRole = new HashSet<IdentityUserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IdentityUserRole> IdentityUserRole { get; set; }
    }
}
