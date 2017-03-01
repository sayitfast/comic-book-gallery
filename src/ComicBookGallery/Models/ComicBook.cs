using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    // can contain attributes or behaviors.
    public class ComicBook
    {
        // properties
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}