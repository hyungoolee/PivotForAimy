using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class PublishedProgram
    {
        public int Id { get; set; }
        public int SptId { get; set; }
        public string SiteName { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }
        public string ProgramCategory { get; set; }
        public int TypeId { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string TermName { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int? Rating { get; set; }
        public string ImageUrl { get; set; }
        public int? Capacity { get; set; }
        public string SchoolName { get; set; }
        public string Telephone { get; set; }
        public string KeyWord { get; set; }
        public string CountryName { get; set; }
        public string PostalCode { get; set; }
    }
}
