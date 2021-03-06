﻿using System;
using System.Windows.Forms;
using FlickrViewerApplication.Dto;

namespace FlickrViewerApplication
{
    public partial class FlickrPhotoViewer : Form
    {
        public FlickrPhotoViewer(FlickrResponseItemsDto flickrResponseItemDto)
        {
            InitializeComponent();
            SetControlsForPhotoViewer(flickrResponseItemDto);
        }

        public void SetControlsForPhotoViewer(FlickrResponseItemsDto flickrResponseItemDto)
        {
            TitleLabel.Text = flickrResponseItemDto.Title;
            DescriptionBox.Text = flickrResponseItemDto.Description;
            var publishDateTime = Convert.ToDateTime(flickrResponseItemDto.Published);
            PublishLabel.Text = Constants.PublishedOnString + publishDateTime.ToString("yyyy-MM-dd-HH:mm:ss");
            ImageBox.ImageLocation = flickrResponseItemDto.Media.m;
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}