using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroAccountCode
    {
        public XeroAccountCode()
        {
            OrgSettingDefaultCcaccCode = new HashSet<OrgSetting>();
            OrgSettingDefaultOpaccCode = new HashSet<OrgSetting>();
            OrgSettingDefaultOscarbankAccCode = new HashSet<OrgSetting>();
            SubsidyPayment = new HashSet<SubsidyPayment>();
        }

        public int Id { get; set; }
        public int OrgId { get; set; }
        public Guid XeroTransactionId { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TaxRate { get; set; }
        public DateTime? XeroLastUpdatedUtc { get; set; }
        public string XeroStatus { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] Version { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<OrgSetting> OrgSettingDefaultCcaccCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultOpaccCode { get; set; }
        public virtual ICollection<OrgSetting> OrgSettingDefaultOscarbankAccCode { get; set; }
        public virtual ICollection<SubsidyPayment> SubsidyPayment { get; set; }
        public virtual Org Org { get; set; }
    }
}
