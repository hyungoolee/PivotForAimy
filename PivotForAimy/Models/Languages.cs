using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class Languages
    {
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }
}
