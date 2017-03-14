using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PublicHoliday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }

        public virtual Country Country { get; set; }
    }
}
