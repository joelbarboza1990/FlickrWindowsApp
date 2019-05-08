using System;
using FlickrViewerApplication.Dto;
using FlickrViewerApplication.Interfaces;
using Newtonsoft.Json;

namespace FlickrViewerApplication.Services
{
    public class FlickrService : IFlickrService
    {
        /// <summary>
        /// Method to build Flickr Json data
        /// </summary>
        /// <param name="data">data to be converted to Dto</param>
        /// <returns>flickrresponse dto</returns>
        public FlickrResponseDto BuildFlickrJsonData(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            FlickrResponseDto flickrResponseDto;
            try
            {
                var removedData = data.Replace(Constants.JsonStringValueToReplaceString, string.Empty);
                var newString = removedData.Remove(removedData.Length - 1);
                flickrResponseDto = JsonConvert.DeserializeObject<FlickrResponseDto>(newString);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return flickrResponseDto;
        }
    }
}