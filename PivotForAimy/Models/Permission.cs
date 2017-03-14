using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Permission
    {
        public Permission()
        {
            UserPermission = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string DetailedDescription { get; set; }
        public bool? DefaultAccess { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<UserPermission> UserPermission { get; set; }
        public virtual Lookup Role { get; set; }
    }
}
