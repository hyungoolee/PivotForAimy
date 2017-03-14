using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Territory
    {
        public Territory()
        {
            Org = new HashSet<Org>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MfranchiseeId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<Org> Org { get; set; }
        public virtual Org Mfranchisee { get; set; }
    }
}
