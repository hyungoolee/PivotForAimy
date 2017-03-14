using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class WaitingList
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public int BookingId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual SiteProgramTerm Spt { get; set; }
    }
}
