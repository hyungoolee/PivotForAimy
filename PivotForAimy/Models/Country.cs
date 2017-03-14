using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            OrgCustomize = new HashSet<OrgCustomize>();
            PublicHoliday = new HashSet<PublicHoliday>();
        }

        public int Id { get; set; }
        public string Iso2 { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public string Iso3 { get; set; }
        public string NumCode { get; set; }
        public string UnmemberState { get; set; }
        public string CallingCode { get; set; }
        public string Cctld { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<OrgCustomize> OrgCustomize { get; set; }
        public virtual ICollection<PublicHoliday> PublicHoliday { get; set; }
    }
}
