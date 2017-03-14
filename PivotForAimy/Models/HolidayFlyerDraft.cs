using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class HolidayFlyerDraft
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public int TemplateId { get; set; }
        public string FlyerData { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual SiteProgramTerm Spt { get; set; }
    }
}
