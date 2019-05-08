namespace FlickrViewerApplication
{
    partial class FlickrPhotoViewer
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.PublishLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.ImageBox.Location = new System.Drawing.Point(12, 114);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(598, 566);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1199, 56);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Loading Please Wait ...";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(643, 217);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(568, 463);
            this.DescriptionBox.TabIndex = 7;
            this.DescriptionBox.Text = "";
            // 
            // PublishLabel
            // 
            this.PublishLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishLabel.Location = new System.Drawing.Point(639, 123);
            this.PublishLabel.Name = "PublishLabel";
            this.PublishLabel.Size = new System.Drawing.Size(369, 56);
            this.PublishLabel.TabIndex = 8;
            this.PublishLabel.Text = "Loading Please Wait ...";
            this.PublishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlickrPhotoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 692);
            this.Controls.Add(this.PublishLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ImageBox);
            this.Name = "FlickrPhotoViewer";
            this.Text = "FlickrPhotoViewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label PublishLabel;
    }
}