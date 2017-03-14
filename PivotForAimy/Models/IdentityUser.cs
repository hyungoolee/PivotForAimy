using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class IdentityUser
    {
        public IdentityUser()
        {
            IdentityUserClaim = new HashSet<IdentityUserClaim>();
            IdentityUserDevice = new HashSet<IdentityUserDevice>();
            IdentityUserLogin = new HashSet<IdentityUserLogin>();
            IdentityUserRole = new HashSet<IdentityUserRole>();
            NotificationMobile = new HashSet<NotificationMobile>();
            PnmessageUser = new HashSet<PnmessageUser>();
            Pnqueue = new HashSet<Pnqueue>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public int AccessFailedCount { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string PasswordHash { get; set; }
        public string ExtraPassword { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string RefreshTokenIssueId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<IdentityUserClaim> IdentityUserClaim { get; set; }
        public virtual ICollection<IdentityUserDevice> IdentityUserDevice { get; set; }
        public virtual ICollection<IdentityUserLogin> IdentityUserLogin { get; set; }
        public virtual ICollection<IdentityUserRole> IdentityUserRole { get; set; }
        public virtual ICollection<NotificationMobile> NotificationMobile { get; set; }
        public virtual ICollection<PnmessageUser> PnmessageUser { get; set; }
        public virtual ICollection<Pnqueue> Pnqueue { get; set; }
        public virtual User User { get; set; }
    }
}
