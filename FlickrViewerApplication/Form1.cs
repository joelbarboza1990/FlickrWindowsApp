using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Script.Serialization;
using System.IO;
using TweetSharp;
using Newtonsoft.Json;

namespace FlickrViewerApplication
{
    public partial class FlickrViewer : Form
    {
        public FlickrViewer()
        {
            InitializeComponent();
            label1.Text = "";
            this.ActiveControl = searchBox;
            searchBox.Focus();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(searchBox.Text.Equals(string.Empty))return;
            if (e.KeyCode == Keys.Enter)
            {
                //panel1.Visible = false;
                label1.Text = "Please wait loading ...";
                getTweets(searchBox.Text);
                panel1.Visible = true;
                listView1.Items.Clear();
                GetFileInformation(searchBox.Text);

                label2.Text = "Tweets for " + searchBox.Text;
            }
        }

        private async void GetFileInformation(string value)
        {
            var url = "http://api.flickr.com/services/feeds/photos_public.gne?tags="+value+"&tagmode=any&format=json";
            
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        var data = fileJsonString;
                        var jsonFlickrObj = BuildJsonData(data);
                        label1.Text = jsonFlickrObj.title;
                        
                        DisplayData(jsonFlickrObj);

                    }
                }
            }
        }

        private static jsonFlickr BuildJsonData(string data)
        {
            var removedData = data.Replace("jsonFlickrFeed(", "");
            string newString = removedData.Remove(removedData.Length - 1);
            var jobject = Newtonsoft.Json.JsonConvert.DeserializeObject<jsonFlickr>(newString);
            return jobject;
        }

        private void DisplayData(jsonFlickr flickrObj)
        {
            if(flickrObj.items == null) return;
            List<string> imageList = (from obj in flickrObj.items where obj.media != null select obj.media.m).ToList();
            ImageList img = new ImageList
            {
                ImageSize = new Size(200, 200),
                ColorDepth = ColorDepth.Depth32Bit
            };
            if (flickrObj.items.Count == 0)
            {
                label1.Text = "No Items returned for search "+ searchBox.Text;
            }
            for (int i = 0; i < flickrObj.items.Count; i++)
            {
                var imageObjLink = flickrObj.items[i].media;
                Image im;
                try
                {
                    WebClient w = new WebClient();
                    byte[] imageByte = w.DownloadData(imageObjLink.m);
                    if (imageByte == null) continue;

                    var stream = new MemoryStream(imageByte);
                    im = Image.FromStream(stream);
                }
                catch (Exception exception)
                {
                    continue;
                }
                
                
                img.Images.Add(im);


                Uri uri = new Uri(imageList[i]);
                listView1.Items.Add(flickrObj.items[i].tags, i);
            }
            listView1.LargeImageList = img;
        }

        private void getTweets(string keyword)
        {
            string _consumerKey = "MhahGOxxlpo5eIwfvgqm8MM30";
            string _consumerSecret = "vupTzaTaAE5SERotaQl8IhsMCZiwDIukKFmiETCsw1FkD08QPk"; // Your key  
            string _accessToken = "357611961-bgTltJYoOC2fSGD4acF4UqUIPH7iXIiAQzmrmOMk"; // Your key  
            string _accessTokenSecret = "AMRu5ZQLqTPJLNQLHqAYjn7qiAGSAja9WXBvmXrX9PCrD"; // Your key  

        TwitterService twitterService = new TwitterService(_consumerKey, _consumerSecret);
            twitterService.AuthenticateWith(_accessToken, _accessTokenSecret);
            
            
            var tweets_search = twitterService.Search(new SearchOptions { Q = keyword,  Count = 100});//Resulttype = TwitterSearchResultType.Recent,
            //Resulttype can be TwitterSearchResultType.Popular or TwitterSearchResultType.Mixed or TwitterSearchResultType.Recent  
            List<TwitterStatus> resultList = new List<TwitterStatus>(tweets_search.Statuses);
            //listBox1.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "Tweets for " + keyword;
            //dataGridView1.Columns[1].HeaderText = "UserName ";
            //dataGridView1.Columns[2].HeaderText = "Tweet";
            int index = 0;
            foreach (var tweet in resultList)
            {
                try
                {
                    //List<Label> labels = new List<Label>();
                    //for (int i = 0; i <= 5; i++)
                    //{
                    //RichTextBox label = new RichTextBox();
                    //label.Top = topControl*25;
                    //label.Name = "lbl" + tweet.Id;
                    //label1.Size = new System.Drawing.Size(430, 80);
                    //label1.TabIndex = 0;
                    //label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    dataGridView1.Rows.Add(tweet.Author.ScreenName+" tweeted"+tweet.Text);//,"at" + tweet.CreatedDate);


                    //this.richTextBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //this.richTextBox2.Location = new System.Drawing.Point(3, 13);
                    //this.richTextBox2.Name = "richTextBox2";
                    //this.richTextBox2.Size = new System.Drawing.Size(430, 80);
                    //this.richTextBox2.TabIndex = 0;
                    //this.richTextBox2.Text = "This is a test the I\'m writing here to see whaat happens in the rich text box\n";
                    //this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);

                    //panel3.Controls.Add(label);
                    //topControl++;
                    //}


                    //for (int col = 0; col < 2; col++)
                    //{
                    //    for (int row = 0; row < 2; row++)
                    //    {
                    //        RichTextBox richTB = new RichTextBox();
                    //        richTB.Name = "textBox" + col + row;
                    //        tableLayoutPanel1.Controls.Add(richTB);
                    //        tableLayoutPanel1.SetColumn(richTB, col);
                    //        tableLayoutPanel1.SetRow(richTB, row);
                    //    }
                    //}

                    //listView2.Items.Add("UserName " + tweet.User + " tweeted: " + tweet.Text + " at" +
                    //                    tweet.CreatedDate);
                    //tweet.User.ScreenName;  
                    //tweet.User.Name;   
                    //tweet.Text; // Tweet text  
                    //tweet.RetweetCount; //No of retweet on twitter  
                    //tweet.User.FavouritesCount; //No of Fav mark on twitter  
                    //tweet.User.ProfileImageUrl; //Profile Image of Tweet  
                    //tweet.CreatedDate; //For Tweet posted time  
                    //"https://twitter.com/intent/retweet?tweet_id=" + tweet.Id;  //For Retweet  
                    //"https://twitter.com/intent/tweet?in_reply_to=" + tweet.Id; //For Reply  
                    //"https://twitter.com/intent/favorite?tweet_id=" + tweet.Id; //For Favorite  
                    //listBox1.Items.Add("UserName " + tweet.User + " tweeted: " + tweet.Text + " at" + tweet.CreatedDate);
                    
                }
                
                catch (Exception ex)
                {
                    throw new Exception("ex:"+ex.Message);
                }
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void label1_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click_2(object sender, EventArgs e)
        //{

        //}
    }
}
