using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FlickrViewerApplication.Interfaces;
using System.Net.Http.Formatting;

namespace FlickrViewerApplication.Services
{
    public class FlickrApiService : IFlickrApiService
    {
        public string GetImages(string value)
        {
            
            string response = string.Empty;
            try
            {
                string url =
                    $"http://api.flickr.com/services/feeds/photos_public.gne?tags={value}&tagmode=any&format=json";
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                request.Method = "GET";

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
    }
}