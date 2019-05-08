using System.Drawing;
using System.Windows.Forms;

namespace FlickrViewerApplication
{
    partial class FlickrViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle TwitterGridViewStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle TwitterGridViewStyleCell = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ImageViewer = new System.Windows.Forms.ListView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TweetLabel = new System.Windows.Forms.Label();
            this.TweeterGridView = new System.Windows.Forms.DataGridView();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TweeterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(527, 33);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Padding = new System.Windows.Forms.Padding(2);
            this.SearchLabel.Size = new System.Drawing.Size(62, 22);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(595, 31);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(536, 26);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // ImageViewer
            // 
            this.ImageViewer.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageViewer.Location = new System.Drawing.Point(5, 12);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(856, 640);
            this.ImageViewer.TabIndex = 3;
            this.ImageViewer.UseCompatibleStateImageBehavior = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TweetLabel);
            this.MainPanel.Controls.Add(this.TweeterGridView);
            this.MainPanel.Controls.Add(this.ImageViewer);
            this.MainPanel.Location = new System.Drawing.Point(7, 170);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1682, 667);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.Visible = false;
            // 
            // TweetLabel
            // 
            this.TweetLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TweetLabel.Location = new System.Drawing.Point(867, 12);
            this.TweetLabel.Name = "TweetLabel";
            this.TweetLabel.Size = new System.Drawing.Size(801, 56);
            this.TweetLabel.TabIndex = 5;
            this.TweetLabel.Text = "Loading Please Wait ...";
            this.TweetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TweeterGridView
            // 
            TwitterGridViewStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            TwitterGridViewStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            TwitterGridViewStyle.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TwitterGridViewStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            TwitterGridViewStyle.NullValue = null;
            TwitterGridViewStyle.Padding = new System.Windows.Forms.Padding(5);
            TwitterGridViewStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            TwitterGridViewStyle.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            TwitterGridViewStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TweeterGridView.ColumnHeadersDefaultCellStyle = TwitterGridViewStyle;
            this.TweeterGridView.ColumnHeadersHeight = 100;
            this.TweeterGridView.ColumnHeadersVisible = false;
            TwitterGridViewStyleCell.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            TwitterGridViewStyleCell.BackColor = System.Drawing.SystemColors.Window;
            TwitterGridViewStyleCell.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TwitterGridViewStyleCell.ForeColor = System.Drawing.SystemColors.ControlText;
            TwitterGridViewStyleCell.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            TwitterGridViewStyleCell.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            TwitterGridViewStyleCell.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TweeterGridView.DefaultCellStyle = TwitterGridViewStyleCell;
            this.TweeterGridView.Location = new System.Drawing.Point(867, 85);
            this.TweeterGridView.Name = "TweeterGridView";
            this.TweeterGridView.RowHeadersVisible = false;
            this.TweeterGridView.Size = new System.Drawing.Size(812, 567);
            this.TweeterGridView.TabIndex = 4;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(9, 84);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(1677, 56);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading Please Wait ...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlickrViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1708, 849);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "FlickrViewer";
            this.Text = "Flickr Viewer";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TweeterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ListView ImageViewer;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LoadingLabel;
        private DataGridView TweeterGridView;
        private Label TweetLabel;
    }
}

