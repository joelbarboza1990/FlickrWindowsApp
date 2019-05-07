using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickrViewerApplication
{
    public partial class FlickrPhotoViewer : Form
    {
        public FlickrPhotoViewer(FlickrResponseItemsDto flickrResponseItemDto)
        {
            InitializeComponent();
            TitleLabel.Text = flickrResponseItemDto.Title;
            DescriptionBox.Text = flickrResponseItemDto.Description;
            DateTime oDate = Convert.ToDateTime(flickrResponseItemDto.Published);
            PublishLabel.Text = "Published on "+ oDate.ToString("yyyy-MM-dd-HH:mm:ss");
            pictureBox1.ImageLocation = flickrResponseItemDto.Media.m;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlickrPhotoViewer_Load(object sender, EventArgs e)
        {

        }

        private void tweetLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
