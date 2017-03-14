using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }
    }
}
