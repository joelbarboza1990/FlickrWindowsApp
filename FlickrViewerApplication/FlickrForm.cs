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
                        loadingLabel.Text = jsonFlickrObj.Title;
                        DisplayData(jsonFlickrObj);
                    }
                }
            }
        }

        FlickrResponseDto _flickrResponseDto = new FlickrResponseDto();
        private FlickrResponseDto BuildJsonData(string data)
        {
            var removedData = data.Replace("jsonFlickrFeed(", "");
            var newString = removedData.Remove(removedData.Length - 1);
            var jsonFlickr = JsonConvert.DeserializeObject<FlickrResponseDto>(newString);
            _flickrResponseDto = jsonFlickr;
            return jsonFlickr;
        }

        private void DisplayData(FlickrResponseDto flickrObj)
        {
            if (flickrObj.Items == null) return;
            var imageList = (from obj in flickrObj.Items where obj.Media != null select obj.Media.m).ToList();
            var img = new ImageList
            {
                ImageSize = new Size(230, 200),
                ColorDepth = ColorDepth.Depth32Bit
            };
            if (flickrObj.Items.Count == 0)
            {
                loadingLabel.Text = "No Items returned for search " + searchBox.Text;
            }
            for (var i = 0; i < flickrObj.Items.Count; i++)
            {
                var imageObjLink = flickrObj.Items[i].Media;
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
                ImageViewer.Items.Add(flickrObj.Items[i].Title, i);
            }
            ImageViewer.MouseDoubleClick += new MouseEventHandler(ImageViewerDoubleClickEvent);
            ImageViewer.LargeImageList = img;
        }

        private void ImageViewerDoubleClickEvent(object sender, MouseEventArgs e)
        {
            var itemIndex = ImageViewer.SelectedItems[0];
            var selectedImage = new FlickrResponseItemsDto();
            for (int i = 0; i <= _flickrResponseDto.Items.Count; i++)
            {
                if(i != itemIndex.Index) continue;
                selectedImage = _flickrResponseDto.Items[i];
            }
            var flickrPhotoViewer = new FlickrPhotoViewer(selectedImage);
            flickrPhotoViewer.Show();
            //MessageBox.Show("you clicked a image " + selectedImage.Title+" user "+selectedImage.Author+ " published date"+ selectedImage.Published);
        }


        private void GetTweets(string keyword)
        {
            var _consumerKey = "MhahGOxxlpo5eIwfvgqm8MM30";
            var _consumerSecret = "vupTzaTaAE5SERotaQl8IhsMCZiwDIukKFmiETCsw1FkD08QPk"; 
            var _accessToken = "357611961-bgTltJYoOC2fSGD4acF4UqUIPH7iXIiAQzmrmOMk"; 
            var _accessTokenSecret = "AMRu5ZQLqTPJLNQLHqAYjn7qiAGSAja9WXBvmXrX9PCrD";

            var twitterService = new TwitterService(_consumerKey, _consumerSecret);
            twitterService.AuthenticateWith(_accessToken, _accessTokenSecret);

            var tweetsSearch = twitterService.Search(new SearchOptions {Q = keyword, Count = 100});
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