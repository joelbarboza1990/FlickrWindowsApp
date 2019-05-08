using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FlickrViewerApplication.Dto;
using FlickrViewerApplication.Interfaces;
using FlickrViewerApplication.Services;
using TweetSharp;

namespace FlickrViewerApplication
{
    public partial class FlickrViewer : Form
    {
        private FlickrResponseDto _flickrResponseDto = new FlickrResponseDto();
        private readonly IFlickrApiService _iFlickrApiService = new FlickrApiService();
        private readonly IFlickrService _iFlickrService = new FlickrService();

        public FlickrViewer()
        {
            InitializeComponent();
            SetControlsOnFormLoad();
        }

        private void SetControlsOnFormLoad()
        {
            LoadingLabel.Text = Constants.HelpString;
            ActiveControl = SearchBox;
            SearchBox.Focus();
            HideControls();
        }

        private void HideControls()
        {
            ImageViewer.Hide();
            TweetLabel.Hide();
            TweeterGridView.Hide();
            ViewImageButton.Hide();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchBox.Text.Equals(string.Empty)) return;
            if (e.KeyCode == Keys.Enter)
            {
                LoadingLabel.Text = Constants.LoadingDataString;
                TweetLabel.Text = Constants.LoadingDataString;
                SetControlsOnEnterKey();
            }
        }

        private void SetControlsOnEnterKey()
        {
            GetTweets(SearchBox.Text);
            GetImages(SearchBox.Text);
            ShowControls();
        }

        private void ShowControls()
        {
            ImageViewer.Show();
            TweetLabel.Show();
            TweeterGridView.Show();
            ViewImageButton.Show();
        }

        private void GetImages(string value)
        {
            var data = _iFlickrApiService.GetImages(value);
            var jsonFlickrObjDto = _iFlickrService.BuildFlickrJsonData(data);
            _flickrResponseDto = jsonFlickrObjDto;
            if (jsonFlickrObjDto != null)
            {
                LoadingLabel.Text = jsonFlickrObjDto.Title;
                DisplayData(jsonFlickrObjDto);
            }
        }

        private void DisplayData(FlickrResponseDto flickrObj)
        {
            if (flickrObj.Items == null) return;
            ImageViewer.Items.Clear();
            if (flickrObj.Items.Count == 0)
            {
                LoadingLabel.Text = Constants.NoImagesReturnedString + SearchBox.Text;
                return;
            }
            var imgList = new ImageList
            {
                ImageSize = new Size(230, 200),
                ColorDepth = ColorDepth.Depth32Bit
            };

            for (var i = 0; i < flickrObj.Items.Count; i++)
            {
                var imageObjLink = flickrObj.Items[i].Media;
                var image = _iFlickrApiService.DownloadImage(imageObjLink.m);
                if (image != null) imgList.Images.Add(image);
                ImageViewer.Items.Add(flickrObj.Items[i].Title, i);
            }
            ImageViewer.MouseClick += ImageViewerSingleClickEvent;
            ImageViewer.LargeImageList = imgList;
        }

        private void ImageViewerSingleClickEvent(object sender, MouseEventArgs e)
        {
            var itemIndex = ImageViewer.SelectedItems[0];
            var selectedImage = new FlickrResponseItemsDto();
            for (var i = 0; i <= _flickrResponseDto.Items.Count; i++)
            {
                if (i != itemIndex.Index) continue;
                selectedObject = _flickrResponseDto.Items[i];
            }
        }

        private FlickrResponseItemsDto selectedObject;
        private void ImageViewerDoubleClickEvent(object sender, MouseEventArgs e)
        {
            var itemIndex = ImageViewer.SelectedItems[0];
            var selectedImage = new FlickrResponseItemsDto();
            for (var i = 0; i <= _flickrResponseDto.Items.Count; i++)
            {
                if (i != itemIndex.Index) continue;
                selectedObject = _flickrResponseDto.Items[i];
            }
            var flickrPhotoViewer = new FlickrPhotoViewer(selectedImage);
            flickrPhotoViewer.Show();
        }

        private void GetTweets(string keyword)
        {
            var resultList = _iFlickrApiService.GetTweets(keyword);
            LoadTwitterGrid(resultList, keyword);
        }

        private void LoadTwitterGrid(List<TwitterStatus> twitterStatuses, string keyword)
        {
            TweetLabel.Text = Constants.TweetLabelPrefixString + SearchBox.Text;
            TweeterGridView.Rows.Clear();
            TweeterGridView.Refresh();
            TweeterGridView.ColumnCount = 1;
            TweeterGridView.Columns[0].HeaderText = Constants.TweetLabelPrefixString + keyword;
            foreach (var tweetStatus in twitterStatuses)
            {
                TweeterGridView.Rows.Add(tweetStatus.Author.ScreenName + " :--> " + tweetStatus.Text + " @" +
                                         tweetStatus.CreatedDate);
            }
            TweeterGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TweeterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewButtonbutton_Click(object sender, System.EventArgs e)
        {
            if (selectedObject != null)
            {
                var flickrPhotoViewer = new FlickrPhotoViewer(selectedObject);
                selectedObject = null;
                flickrPhotoViewer.Show();
            }
            else
            {
                MessageBox.Show(Constants.ViewButtonErrorMessageString);
            }
        }
    }
}