﻿using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class XeroContact
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public Guid XeroContactId { get; set; }
        public string XeroConsumerKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string BillingStreetAddress { get; set; }
        public string BillingSuburb { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostcode { get; set; }
        public string BillingCountry { get; set; }
        public string Fax { get; set; }
        public string Landline { get; set; }
        public string Office { get; set; }
        public string Status { get; set; }
        public DateTime XeroUtcupdatedOn { get; set; }
        public string Mobile { get; set; }

        public virtual Org Org { get; set; }
    }
}
