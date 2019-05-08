using FlickrViewerApplication.Dto;

namespace FlickrViewerApplication.Interfaces
{
    public interface IFlickrService
    {
        FlickrResponseDto BuildFlickrJsonData(string data);
    }
}