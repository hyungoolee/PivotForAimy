using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ChildContact = new HashSet<Child>();
            ChildEmergencyContact1 = new HashSet<Child>();
            ChildEmergencyContact2 = new HashSet<Child>();
            ChildContactNavigation = new HashSet<ChildContact>();
            GuardianChild = new HashSet<GuardianChild>();
            Org = new HashSet<Org>();
            OrgContact = new HashSet<OrgContact>();
            SchoolContact = new HashSet<SchoolContact>();
            SignoutSignature = new HashSet<SignoutSignature>();
            User = new HashSet<User>();
            UserContact = new HashSet<UserContact>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] SignatureImage { get; set; }
        public string LandlineFixed { get; set; }
        public string OfficeFixed { get; set; }
        public string OfficeExtension { get; set; }
        public string FaxFixed { get; set; }
        public string MobileFixed { get; set; }
        public string Email { get; set; }
        public string StreetNum { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string BillingStreetNum { get; set; }
        public string BillingAddress { get; set; }
        public string BillingSuburb { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingCountry { get; set; }
        public string OscarNum { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string Relation { get; set; }
        public string HowHear { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public bool FirstAidCheck { get; set; }
        public DateTime? FirstAidExpireyDate { get; set; }
        public bool PoliceCheck { get; set; }
        public DateTime? PoliceCheckExprieyDate { get; set; }
        public string Notes { get; set; }
        public string DriverLicence { get; set; }
        public string Landline { get; set; }
        public string Office { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string SocialWorkerId { get; set; }
        public string OtherRelation { get; set; }

        public virtual ICollection<Child> ChildContact { get; set; }
        public virtual ICollection<Child> ChildEmergencyContact1 { get; set; }
        public virtual ICollection<Child> ChildEmergencyContact2 { get; set; }
        public virtual ICollection<ChildContact> ChildContactNavigation { get; set; }
        public virtual ICollection<GuardianChild> GuardianChild { get; set; }
        public virtual ICollection<Org> Org { get; set; }
        public virtual ICollection<OrgContact> OrgContact { get; set; }
        public virtual ICollection<SchoolContact> SchoolContact { get; set; }
        public virtual ICollection<SignoutSignature> SignoutSignature { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserContact> UserContact { get; set; }
        public virtual Lookup Gender { get; set; }
    }
}
