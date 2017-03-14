using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class TmpImportCanada
    {
        public int Id { get; set; }
        public string FamilyId { get; set; }
        public string UserName { get; set; }
        public string FamilyName { get; set; }
        public int? Gender { get; set; }
        public string ChildFirst { get; set; }
        public string ChildLast { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string First1 { get; set; }
        public string Last1 { get; set; }
        public string First2 { get; set; }
        public string Last2 { get; set; }
        public string StreetNum1 { get; set; }
        public string StreetNum2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string City1 { get; set; }
        public string City2 { get; set; }
        public string Postcode1 { get; set; }
        public string Postcode2 { get; set; }
    }
}
