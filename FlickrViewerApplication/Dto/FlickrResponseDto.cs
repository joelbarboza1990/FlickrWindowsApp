using System.Collections.Generic;

namespace FlickrViewerApplication.Dto
{
    public class FlickrResponseDto
    {
        public string Description;
        public string Generator;
        public List<FlickrResponseItemsDto> Items;
        public string Link;
        public string Modified;
        public string Title;

        public FlickrResponseDto()
        {
            Description = Generator = Link = Modified = Title = string.Empty;
            Items = null;
        }
    }
}