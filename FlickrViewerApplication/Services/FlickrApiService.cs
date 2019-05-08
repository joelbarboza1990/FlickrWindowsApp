using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using FlickrViewerApplication.Interfaces;
using TweetSharp;

namespace FlickrViewerApplication.Services
{
    public class FlickrApiService : IFlickrApiService
    {
        /// <summary>
        /// Method to get Images from flickr
        /// </summary>
        /// <param name="searchKey">search key to get data from flickr API</param>
        /// <returns>string containing flickr data</returns>
        public string GetImages(string searchKey)
        {
            var response = string.Empty;
            try
            {
                string url = Constants.FlickrUrl + searchKey;
                var request = (HttpWebRequest) WebRequest.Create(url);
                request.Method = Constants.HttpGetOperationString;
                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                if (webStream != null)
                {
                    var responseReader = new StreamReader(webStream);
                    response = responseReader.ReadToEnd();
                    responseReader.Close();
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (WebException exception)
            {
                throw new Exception(exception.Message);
            }
            catch (Exception excep)
            {
                throw new Exception(excep.Message);
            }
            return response;
        }

        /// <summary>
        /// Method to download Image
        /// </summary>
        /// <param name="linkToDownload">link to download image</param>
        /// <returns>image</returns>
        public Image DownloadImage(string linkToDownload)
        {
            if (string.IsNullOrEmpty(linkToDownload)) return null;
            Image image;
            try
            {
                var w = new WebClient();
                var imageByte = w.DownloadData(linkToDownload);
                if (imageByte == null) return null;
                var stream = new MemoryStream(imageByte);
                image = Image.FromStream(stream);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (WebException exception)
            {
                throw new Exception(exception.Message);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return image;
        }
        /// <summary>
        /// Method to get tweets from tweeter API
        /// </summary>
        /// <param name="keyword">keyword to be searched in tweeter Api</param>
        /// <returns>list of data which contain tweeter data</returns>
        public List<TwitterStatus> GetTweets(string keyword)
        {
            var consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            var consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
            var accessToken = ConfigurationManager.AppSettings["AccessToken"];
            var accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];
            TwitterSearchResult tweetsSearch;
            try
            {
                var twitterService = new TwitterService(consumerKey, consumerSecret);
                twitterService.AuthenticateWith(accessToken, accessTokenSecret);
                tweetsSearch = twitterService.Search(new SearchOptions {Q = keyword, Count = 100});
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            
            var resultList = new List<TwitterStatus>(tweetsSearch.Statuses);
            return resultList;
        }
    }
}