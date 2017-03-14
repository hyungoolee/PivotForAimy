using System;
using System.Collections.Generic;

namespace PivotForAimy.Models
{
    public partial class MediaLibrary
    {
        public MediaLibrary()
        {
            MediaLibraryChild = new HashSet<MediaLibraryChild>();
            MediaLibraryMedia = new HashSet<MediaLibraryMedia>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Version { get; set; }

        public virtual ICollection<MediaLibraryChild> MediaLibraryChild { get; set; }
        public virtual ICollection<MediaLibraryMedia> MediaLibraryMedia { get; set; }
    }
}
