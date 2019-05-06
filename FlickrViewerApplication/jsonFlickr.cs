using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewerApplication
{
    public class jsonFlickr
    {
        public string title = string.Empty;
        public string link = string.Empty;
        public string description = string.Empty;

        public string modified = string.Empty;

        public string generator = string.Empty;

        public List<ImageItems> items = null;
        
    }
}
