using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TmpImport
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? DataId { get; set; }
        public string FamilyId { get; set; }
        public string UserName { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] SignatureImage { get; set; }
        public string Landline { get; set; }
        public string Office { get; set; }
        public string OfficeExtension { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string StreetNum { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Relation { get; set; }
        public bool? IsActive { get; set; }
        public byte[] Version { get; set; }
        public int? ParentId { get; set; }
        public string Ethnicity { get; set; }
    }
}
