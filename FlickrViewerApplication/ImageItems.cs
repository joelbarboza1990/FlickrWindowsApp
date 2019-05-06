using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewerApplication
{
    public class ImageItems
    {
        public string title = string.Empty;
        public string link = string.Empty;
        public Media media = null;
        public string date_taken = string.Empty;
        public string description = string.Empty;
        public string published = string.Empty;
        public string author = string.Empty;
        public string author_id = string.Empty;
        public string tags = string.Empty;
    }

    public class Media
    {
        public string m = string.Empty;
    }
}
