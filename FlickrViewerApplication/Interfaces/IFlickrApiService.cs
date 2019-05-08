using System.Collections.Generic;
using System.Drawing;
using TweetSharp;

namespace FlickrViewerApplication.Interfaces
{
    public interface IFlickrApiService
    {
        string GetImages(string value);
        Image DownloadImage(string linkToDownload);
        List<TwitterStatus> GetTweets(string keyword);
    }
}