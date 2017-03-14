using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class BookingHistoryLookup
    {
        public int Id { get; set; }
        public string CallerName { get; set; }
        public string Description { get; set; }
        public bool ShowInBookingHistory { get; set; }
    }
}
