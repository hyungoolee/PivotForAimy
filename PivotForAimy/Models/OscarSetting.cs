using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OscarSetting
    {
        public OscarSetting()
        {
            UserOscarSetting = new HashSet<UserOscarSetting>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public string ProgramManagerName { get; set; }
        public string ProgramMangerPhone { get; set; }
        public string ProgramManagerEmail { get; set; }
        public string Signature { get; set; }
        public bool? UseDefaultEmails { get; set; }
        public string OscarApplicationRequestEmail { get; set; }
        public string OscarApplicationApproval { get; set; }
        public string OscarApplicationDeclined { get; set; }
        public string OscarDeclarationRequest { get; set; }
        public string OscarDeclarationApproval { get; set; }
        public string OscarDeclarationDeclined { get; set; }
        public string OscarDeclaration4WeeksOut { get; set; }
        public string OscarDeclaration3WeeksOut { get; set; }
        public string OscarDeclaration2WeeksOut { get; set; }
        public string OscarDeclaration1WeeksOut { get; set; }
        public string OscarCocrequest { get; set; }
        public string OscarRenewalRequest { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserOscarSetting> UserOscarSetting { get; set; }
        public virtual Org Org { get; set; }
    }
}
