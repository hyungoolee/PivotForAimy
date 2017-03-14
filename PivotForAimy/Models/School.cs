using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class School
    {
        public School()
        {
            Child = new HashSet<Child>();
            Org = new HashSet<Org>();
            SchoolContact = new HashSet<SchoolContact>();
            SchoolOrg = new HashSet<SchoolOrg>();
        }

        public int Id { get; set; }
        public int? SchoolNumber { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Principal { get; set; }
        public string Website { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalCode { get; set; }
        public string UrbanArea { get; set; }
        public string SchoolType { get; set; }
        public string Definition { get; set; }
        public string Authority { get; set; }
        public string GenderOfStudents { get; set; }
        public string TerritorialAuthority { get; set; }
        public string RegionalCouncil { get; set; }
        public string MinistryOfEducationLocalOffice { get; set; }
        public string EducationRegion { get; set; }
        public string Ward { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public int? Decile { get; set; }
        public int? TotalRoll { get; set; }
        public int? EuropeanPakeha { get; set; }
        public int? Maori { get; set; }
        public int? Pasifika { get; set; }
        public int? Asian { get; set; }
        public int? Melaa { get; set; }
        public int? OtherEthnicity { get; set; }
        public int? InternationalStudents { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }
        public int? CountryId { get; set; }
        public string DefaultTimeZone { get; set; }

        public virtual ICollection<Child> Child { get; set; }
        public virtual ICollection<Org> Org { get; set; }
        public virtual ICollection<SchoolContact> SchoolContact { get; set; }
        public virtual ICollection<SchoolOrg> SchoolOrg { get; set; }
        public virtual School IdNavigation { get; set; }
        public virtual School InverseIdNavigation { get; set; }
    }
}
