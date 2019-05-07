using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlickrViewerApplication
{
    public class FlickrResponseDto
    {
        public string Title = string.Empty;
        public string Link = string.Empty;
        public string Description = string.Empty;
        public string Modified = string.Empty;
        public string Generator = string.Empty;
        public List<FlickrResponseItemsDto> Items = null;
    }
}
