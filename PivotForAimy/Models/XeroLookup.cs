using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroLookup
    {
        public XeroLookup()
        {
            OrgSetting = new HashSet<OrgSetting>();
            XeroInvoice = new HashSet<XeroInvoice>();
        }

        public int Id { get; set; }
        public string EntityName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Index { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<OrgSetting> OrgSetting { get; set; }
        public virtual ICollection<XeroInvoice> XeroInvoice { get; set; }
    }
}
