using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class CssCreditCardAccessCode
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string AccessCode { get; set; }
        public bool IsActive { get; set; }

        public virtual Org Site { get; set; }
    }
}
