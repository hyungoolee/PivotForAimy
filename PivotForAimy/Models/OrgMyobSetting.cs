using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class OrgMyobSetting
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string ClientKey { get; set; }
        public string SecretKey { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpireDate { get; set; }
        public string MyobSoftwareType { get; set; }
        public string MyobGid { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Org Org { get; set; }
    }
}
