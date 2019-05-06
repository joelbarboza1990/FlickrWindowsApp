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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.ImageViewer = new System.Windows.Forms.ListView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tweetLabel = new System.Windows.Forms.Label();
            this.tweeterGridView = new System.Windows.Forms.DataGridView();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tweeterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(527, 33);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Padding = new System.Windows.Forms.Padding(2);
            this.searchLabel.Size = new System.Drawing.Size(62, 22);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(595, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(536, 26);
            this.searchBox.TabIndex = 1;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
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
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tweetLabel);
            this.mainPanel.Controls.Add(this.tweeterGridView);
            this.mainPanel.Controls.Add(this.ImageViewer);
            this.mainPanel.Location = new System.Drawing.Point(7, 170);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1682, 667);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Visible = false;
            // 
            // tweetLabel
            // 
            this.tweetLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweetLabel.Location = new System.Drawing.Point(867, 12);
            this.tweetLabel.Name = "tweetLabel";
            this.tweetLabel.Size = new System.Drawing.Size(801, 56);
            this.tweetLabel.TabIndex = 5;
            this.tweetLabel.Text = "Loading Please Wait ...";
            this.tweetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tweeterGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tweeterGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tweeterGridView.ColumnHeadersHeight = 100;
            this.tweeterGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tweeterGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tweeterGridView.Location = new System.Drawing.Point(867, 85);
            this.tweeterGridView.Name = "tweeterGridView";
            this.tweeterGridView.RowHeadersVisible = false;
            this.tweeterGridView.Size = new System.Drawing.Size(812, 567);
            this.tweeterGridView.TabIndex = 4;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(9, 84);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(1677, 56);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "Loading Please Wait ...";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlickrViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1708, 849);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "FlickrViewer";
            this.Text = "Flickr Viewer";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tweeterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListView ImageViewer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label loadingLabel;
        private DataGridView tweeterGridView;
        private Label tweetLabel;
    }
}

