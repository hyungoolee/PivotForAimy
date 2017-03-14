﻿using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MediaLibraryChild
    {
        public int Id { get; set; }
        public int MediaLibraryId { get; set; }
        public int ChildId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual MediaLibrary MediaLibrary { get; set; }
    }
}
