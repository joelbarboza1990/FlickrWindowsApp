using System.Threading.Tasks;

namespace FlickrViewerApplication.Interfaces
{
    public interface IFlickrApiService
    {
       string GetImages(string value);
    }
}