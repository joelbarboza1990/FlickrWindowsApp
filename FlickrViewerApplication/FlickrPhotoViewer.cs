using System;
using System.Windows.Forms;
using FlickrViewerApplication.Dto;

namespace FlickrViewerApplication
{
    public partial class FlickrPhotoViewer : Form
    {
        public FlickrPhotoViewer(FlickrResponseItemsDto flickrResponseItemDto)
        {
            InitializeComponent();
            TitleLabel.Text = flickrResponseItemDto.Title;
            DescriptionBox.Text = flickrResponseItemDto.Description;
            var publishDateTime = Convert.ToDateTime(flickrResponseItemDto.Published);
            PublishLabel.Text = "Published on " + publishDateTime.ToString("yyyy-MM-dd-HH:mm:ss");
            ImageBox.ImageLocation = flickrResponseItemDto.Media.m;
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}