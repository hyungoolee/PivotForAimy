using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgSetting
    {
        public OrgSetting()
        {
            DeletingInvoiceQueue = new HashSet<DeletingInvoiceQueue>();
        }

        public int OrgId { get; set; }
        public decimal? ExtraMinRate { get; set; }
        public string XeroConsumerKey { get; set; }
        public int? DefaultAscptitemCodeId { get; set; }
        public int? DefaultAscftitemCodeId { get; set; }
        public int? DefaultAsccitemCodeId { get; set; }
        public int? DefaultBscptitemCodeId { get; set; }
        public int? DefaultBscftitemCodeId { get; set; }
        public int? DefaultBsccitemCodeId { get; set; }
        public int? DefaultHolfitemCodeId { get; set; }
        public int? DefaultSpecialItemCodeId { get; set; }
        public int? DefaultAsctrackingId { get; set; }
        public int? DefaultBsctrackingId { get; set; }
        public int? DefaultHolTrackingId { get; set; }
        public int? DefaultSpecialTrackingId { get; set; }
        public int? DefaultCcaccCodeId { get; set; }
        public int? DefaultOpaccCodeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? DefaultHolpamitemCodeId { get; set; }
        public int? DefaultHolppmitemCodeId { get; set; }
        public int? DefaultHolsitemCodeId { get; set; }
        public int? DefaultHoltitemCodeId { get; set; }
        public int? InvoiceStatusTypeId { get; set; }
        public int? DefaultOscarbankAccCodeId { get; set; }

        public virtual ICollection<DeletingInvoiceQueue> DeletingInvoiceQueue { get; set; }
        public virtual XeroItemCode DefaultAsccitemCode { get; set; }
        public virtual XeroItemCode DefaultAscftitemCode { get; set; }
        public virtual XeroItemCode DefaultAscptitemCode { get; set; }
        public virtual XeroTrackingCatOption DefaultAsctracking { get; set; }
        public virtual XeroItemCode DefaultBsccitemCode { get; set; }
        public virtual XeroItemCode DefaultBscftitemCode { get; set; }
        public virtual XeroItemCode DefaultBscptitemCode { get; set; }
        public virtual XeroTrackingCatOption DefaultBsctracking { get; set; }
        public virtual XeroAccountCode DefaultCcaccCode { get; set; }
        public virtual XeroTrackingCatOption DefaultHolTracking { get; set; }
        public virtual XeroItemCode DefaultHolfitemCode { get; set; }
        public virtual XeroItemCode DefaultHolpamitemCode { get; set; }
        public virtual XeroItemCode DefaultHolppmitemCode { get; set; }
        public virtual XeroItemCode DefaultHolsitemCode { get; set; }
        public virtual XeroItemCode DefaultHoltitemCode { get; set; }
        public virtual XeroAccountCode DefaultOpaccCode { get; set; }
        public virtual XeroAccountCode DefaultOscarbankAccCode { get; set; }
        public virtual XeroItemCode DefaultSpecialItemCode { get; set; }
        public virtual XeroTrackingCatOption DefaultSpecialTracking { get; set; }
        public virtual XeroLookup InvoiceStatusType { get; set; }
        public virtual Org Org { get; set; }
    }
}
