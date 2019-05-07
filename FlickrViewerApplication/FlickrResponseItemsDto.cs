using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewerApplication
{
    public class FlickrResponseItemsDto
    {
        public string Title = string.Empty;
        public string Link = string.Empty;
        public FlickrViewerApplication.Media Media = null;
        public string DateTaken = string.Empty;
        public string Description = string.Empty;
        public string Published = string.Empty;
        public string Author = string.Empty;
        public string AuthorId = string.Empty;
        public string Tags = string.Empty;
    }

    public class Media
    {
        public string m = string.Empty;
    }
}
