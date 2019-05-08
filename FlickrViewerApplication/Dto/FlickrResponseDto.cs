using System.Collections.Generic;

namespace FlickrViewerApplication.Dto
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
