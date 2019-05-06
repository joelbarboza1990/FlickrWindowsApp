using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using TweetSharp;

namespace FlickrViewerApplication
{
    public partial class FlickrViewer : Form
    {
        public FlickrViewer()
        {
            InitializeComponent();
            loadingLabel.Text = "";
            ActiveControl = searchBox;
            searchBox.Focus();
            loadingLabel.Show();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchBox.Text.Equals(string.Empty)) return;
            if (e.KeyCode == Keys.Enter)
            {
                loadingLabel.Text = "Loading Data, Please wait ...";
                loadingLabel.Show();
                tweetLabel.Text = "Loading Tweets Please wait...";
                GetTweets(searchBox.Text);
                mainPanel.Visible = true;
                ImageViewer.Items.Clear();
                GetSearchImages(searchBox.Text);
                tweetLabel.Text = "Tweets for " + searchBox.Text;
            }
        }

        private async void GetSearchImages(string value)
        {
            var url = $"http://api.flickr.com/services/feeds/photos_public.gne?tags={value}&tagmode=any&format=json";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        var data = fileJsonString;
                        var jsonFlickrObj = BuildJsonData(data);
                        loadingLabel.Text = jsonFlickrObj.title;
                        DisplayData(jsonFlickrObj);
                    }
                }
            }
        }

        private static jsonFlickr BuildJsonData(string data)
        {
            var removedData = data.Replace("jsonFlickrFeed(", "");
            var newString = removedData.Remove(removedData.Length - 1);
            var jsonFlickr = JsonConvert.DeserializeObject<jsonFlickr>(newString);
            return jsonFlickr;
        }

        private void DisplayData(jsonFlickr flickrObj)
        {
            if (flickrObj.items == null) return;
            var imageList = (from obj in flickrObj.items where obj.media != null select obj.media.m).ToList();
            var img = new ImageList
            {
                ImageSize = new Size(230, 200),
                ColorDepth = ColorDepth.Depth32Bit
            };
            if (flickrObj.items.Count == 0)
            {
                loadingLabel.Text = "No Items returned for search " + searchBox.Text;
            }
            for (var i = 0; i < flickrObj.items.Count; i++)
            {
                var imageObjLink = flickrObj.items[i].media;
                Image im;
                try
                {
                    var w = new WebClient();
                    var imageByte = w.DownloadData(imageObjLink.m);
                    if (imageByte == null) continue;

                    var stream = new MemoryStream(imageByte);
                    im = Image.FromStream(stream);
                }
                catch (Exception exception)
                {
                    continue;
                }

                img.Images.Add(im);


                var uri = new Uri(imageList[i]);
                ImageViewer.Items.Add(flickrObj.items[i].title, i);
            }
            ImageViewer.LargeImageList = img;
        }

        private void GetTweets(string keyword)
        {
            var _consumerKey = "MhahGOxxlpo5eIwfvgqm8MM30";
            var _consumerSecret = "vupTzaTaAE5SERotaQl8IhsMCZiwDIukKFmiETCsw1FkD08QPk"; // Your key  
            var _accessToken = "357611961-bgTltJYoOC2fSGD4acF4UqUIPH7iXIiAQzmrmOMk"; // Your key  
            var _accessTokenSecret = "AMRu5ZQLqTPJLNQLHqAYjn7qiAGSAja9WXBvmXrX9PCrD"; // Your key  

            var twitterService = new TwitterService(_consumerKey, _consumerSecret);
            twitterService.AuthenticateWith(_accessToken, _accessTokenSecret);


            var tweetsSearch = twitterService.Search(new SearchOptions {Q = keyword, Count = 100});
                //Resulttype = TwitterSearchResultType.Recent,
            //Resulttype can be TwitterSearchResultType.Popular or TwitterSearchResultType.Mixed or TwitterSearchResultType.Recent  
            var resultList = new List<TwitterStatus>(tweetsSearch.Statuses);
            tweeterGridView.Rows.Clear();
            tweeterGridView.Refresh();
            tweeterGridView.ColumnCount = 1;
            tweeterGridView.Columns[0].HeaderText = "Tweets for " + keyword;
            foreach (var tweet in resultList)
            {
                tweeterGridView.Rows.Add(tweet.Author.ScreenName + " :--> " + tweet.Text + " @" + tweet.CreatedDate);
            }
            tweeterGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tweeterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}