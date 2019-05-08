namespace FlickrViewerApplication.Dto
{
    public class FlickrResponseItemsDto
    {
        public string Author;
        public string AuthorId;
        public string DateTaken;
        public string Description;
        public string Link;
        public MediaDto Media;
        public string Published;
        public string Tags;
        public string Title;

        public FlickrResponseItemsDto()
        {
            Author = AuthorId = DateTaken = Description = Link = Published = Tags = Title = "";
            Media = null;
        }
    }
}