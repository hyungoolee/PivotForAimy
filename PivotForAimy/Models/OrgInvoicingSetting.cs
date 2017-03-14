using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgInvoicingSetting
    {
        public int OrgId { get; set; }
        public int DayOfDue { get; set; }
        public int DayOfGeneration { get; set; }
        public int WeekOfDue { get; set; }
        public int WeekOfGeneration { get; set; }
        public string ConditionForWeekOfDue { get; set; }
        public string ConditionForWeekOfGen { get; set; }
        public bool InvoiceDate { get; set; }
        public string InvoiceReference { get; set; }
        public bool? IsFirstInvoiceGenerateStraightAway { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public string ClientKey { get; set; }
        public string SecretKey { get; set; }
        public string AccessToken { get; set; }
        public string AccessSecret { get; set; }
        public string RequestToken { get; set; }
        public string RequestSecret { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public string AccountingSoftwareType { get; set; }
        public Guid? AccountingSoftwareOrgGuid { get; set; }
        public string AccountingSoftwareOrgString { get; set; }
        public string QuickBooksDataSource { get; set; }

        public virtual Org Org { get; set; }
    }
}
