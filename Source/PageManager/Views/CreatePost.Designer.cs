namespace FPageManager.Views
{
    partial class CreatePost
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
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPhoto = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbPostText = new System.Windows.Forms.RichTextBox();
            this.rbPublishPost = new System.Windows.Forms.RadioButton();
            this.rbUnPublishPost = new System.Windows.Forms.RadioButton();
            this.grpPost = new System.Windows.Forms.GroupBox();
            this.grpPostType = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pvideo = new System.Windows.Forms.Panel();
            this.tbVideoTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbvideo = new System.Windows.Forms.RichTextBox();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pPhoto = new System.Windows.Forms.Panel();
            this.rtbPhoto = new System.Windows.Forms.RichTextBox();
            this.bPhotoBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OfgPhoto = new System.Windows.Forms.OpenFileDialog();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.OfgVideo = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.grpPost.SuspendLayout();
            this.grpPostType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pvideo.SuspendLayout();
            this.pPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbStatus.Location = new System.Drawing.Point(190, 25);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(70, 22);
            this.rbStatus.TabIndex = 0;
            this.rbStatus.Text = "Status";
            this.rbStatus.UseVisualStyleBackColor = true;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post Type:";
            // 
            // rbPhoto
            // 
            this.rbPhoto.AutoSize = true;
            this.rbPhoto.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbPhoto.Location = new System.Drawing.Point(310, 25);
            this.rbPhoto.Name = "rbPhoto";
            this.rbPhoto.Size = new System.Drawing.Size(68, 22);
            this.rbPhoto.TabIndex = 2;
            this.rbPhoto.Text = "Photo";
            this.rbPhoto.UseVisualStyleBackColor = true;
            this.rbPhoto.CheckedChanged += new System.EventHandler(this.rbPhoto_CheckedChanged);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbVideo.Location = new System.Drawing.Point(416, 25);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(65, 22);
            this.rbVideo.TabIndex = 3;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(60, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post Text";
            // 
            // rtbPostText
            // 
            this.rtbPostText.Location = new System.Drawing.Point(143, 19);
            this.rtbPostText.Name = "rtbPostText";
            this.rtbPostText.Size = new System.Drawing.Size(338, 60);
            this.rtbPostText.TabIndex = 7;
            this.rtbPostText.Text = "";
            // 
            // rbPublishPost
            // 
            this.rbPublishPost.AutoSize = true;
            this.rbPublishPost.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPublishPost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbPublishPost.Location = new System.Drawing.Point(7, 17);
            this.rbPublishPost.Name = "rbPublishPost";
            this.rbPublishPost.Size = new System.Drawing.Size(129, 22);
            this.rbPublishPost.TabIndex = 8;
            this.rbPublishPost.TabStop = true;
            this.rbPublishPost.Text = "Published Post";
            this.rbPublishPost.UseVisualStyleBackColor = true;
            // 
            // rbUnPublishPost
            // 
            this.rbUnPublishPost.AutoSize = true;
            this.rbUnPublishPost.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnPublishPost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbUnPublishPost.Location = new System.Drawing.Point(7, 56);
            this.rbUnPublishPost.Name = "rbUnPublishPost";
            this.rbUnPublishPost.Size = new System.Drawing.Size(149, 22);
            this.rbUnPublishPost.TabIndex = 9;
            this.rbUnPublishPost.TabStop = true;
            this.rbUnPublishPost.Text = "UnPublished Post";
            this.rbUnPublishPost.UseVisualStyleBackColor = true;
            // 
            // grpPost
            // 
            this.grpPost.Controls.Add(this.tbTime);
            this.grpPost.Controls.Add(this.dateTimePicker1);
            this.grpPost.Controls.Add(this.rbUnPublishPost);
            this.grpPost.Controls.Add(this.rbPublishPost);
            this.grpPost.Location = new System.Drawing.Point(4, 329);
            this.grpPost.Name = "grpPost";
            this.grpPost.Size = new System.Drawing.Size(493, 88);
            this.grpPost.TabIndex = 12;
            this.grpPost.TabStop = false;
            // 
            // grpPostType
            // 
            this.grpPostType.Controls.Add(this.label1);
            this.grpPostType.Controls.Add(this.rbVideo);
            this.grpPostType.Controls.Add(this.rbStatus);
            this.grpPostType.Controls.Add(this.rbPhoto);
            this.grpPostType.Location = new System.Drawing.Point(4, 3);
            this.grpPostType.Name = "grpPostType";
            this.grpPostType.Size = new System.Drawing.Size(493, 54);
            this.grpPostType.TabIndex = 13;
            this.grpPostType.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pvideo);
            this.groupBox3.Controls.Add(this.pPhoto);
            this.groupBox3.Controls.Add(this.rtbPostText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(4, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 226);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // pvideo
            // 
            this.pvideo.Controls.Add(this.tbVideoTitle);
            this.pvideo.Controls.Add(this.label7);
            this.pvideo.Controls.Add(this.rtbvideo);
            this.pvideo.Controls.Add(this.btnVideoBrowse);
            this.pvideo.Controls.Add(this.label6);
            this.pvideo.Location = new System.Drawing.Point(42, 84);
            this.pvideo.Name = "pvideo";
            this.pvideo.Size = new System.Drawing.Size(439, 112);
            this.pvideo.TabIndex = 11;
            // 
            // tbVideoTitle
            // 
            this.tbVideoTitle.Location = new System.Drawing.Point(99, 87);
            this.tbVideoTitle.Name = "tbVideoTitle";
            this.tbVideoTitle.Size = new System.Drawing.Size(282, 20);
            this.tbVideoTitle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(42, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Title";
            // 
            // rtbvideo
            // 
            this.rtbvideo.Location = new System.Drawing.Point(99, 12);
            this.rtbvideo.Name = "rtbvideo";
            this.rtbvideo.Size = new System.Drawing.Size(282, 56);
            this.rtbvideo.TabIndex = 10;
            this.rtbvideo.Text = "";
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoBrowse.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVideoBrowse.Location = new System.Drawing.Point(387, 16);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(47, 42);
            this.btnVideoBrowse.TabIndex = 9;
            this.btnVideoBrowse.Text = "........";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Click += new System.EventHandler(this.btnVideoBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(33, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Video";
            // 
            // pPhoto
            // 
            this.pPhoto.Controls.Add(this.rtbPhoto);
            this.pPhoto.Controls.Add(this.bPhotoBrowse);
            this.pPhoto.Controls.Add(this.label5);
            this.pPhoto.Location = new System.Drawing.Point(42, 84);
            this.pPhoto.Name = "pPhoto";
            this.pPhoto.Size = new System.Drawing.Size(439, 84);
            this.pPhoto.TabIndex = 8;
            // 
            // rtbPhoto
            // 
            this.rtbPhoto.Location = new System.Drawing.Point(99, 12);
            this.rtbPhoto.Name = "rtbPhoto";
            this.rtbPhoto.Size = new System.Drawing.Size(282, 56);
            this.rtbPhoto.TabIndex = 10;
            this.rtbPhoto.Text = "";
            // 
            // bPhotoBrowse
            // 
            this.bPhotoBrowse.Location = new System.Drawing.Point(387, 16);
            this.bPhotoBrowse.Name = "bPhotoBrowse";
            this.bPhotoBrowse.Size = new System.Drawing.Size(47, 42);
            this.bPhotoBrowse.TabIndex = 9;
            this.bPhotoBrowse.Text = "........";
            this.bPhotoBrowse.UseVisualStyleBackColor = true;
            this.bPhotoBrowse.Click += new System.EventHandler(this.bPhotoBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(33, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "----";
            // 
            // OfgPhoto
            // 
            this.OfgPhoto.FileName = "photo";
            this.OfgPhoto.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Fi" +
    "les (*.gif)|*.gif";
            this.OfgPhoto.Multiselect = true;
            this.OfgPhoto.Title = "Please select an image file to upload";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreatePost.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePost.ForeColor = System.Drawing.Color.White;
            this.btnCreatePost.Location = new System.Drawing.Point(207, 423);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(136, 43);
            this.btnCreatePost.TabIndex = 16;
            this.btnCreatePost.Text = "+ Create Post";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(361, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OfgVideo
            // 
            this.OfgVideo.FileName = "video";
            this.OfgVideo.Filter = "Video files |*.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp;*.asf;  *.avi; *.divx; *.dv; *.f" +
    "lv; *.m2ts; *.m4v; *.mkv; *.mov; *.mp4;*.mpe; *.mpeg; *.mpeg4;*.ogm;";
            this.OfgVideo.Multiselect = true;
            this.OfgVideo.Title = "Please select video file to upload";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(386, 55);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 11;
            // 
            // CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(511, 478);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpPostType);
            this.Controls.Add(this.grpPost);
            this.Controls.Add(this.label2);
            this.Name = "CreatePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Page Post";
            this.grpPost.ResumeLayout(false);
            this.grpPost.PerformLayout();
            this.grpPostType.ResumeLayout(false);
            this.grpPostType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pvideo.ResumeLayout(false);
            this.pvideo.PerformLayout();
            this.pPhoto.ResumeLayout(false);
            this.pPhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPhoto;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbPostText;
        private System.Windows.Forms.RadioButton rbPublishPost;
        private System.Windows.Forms.RadioButton rbUnPublishPost;
        private System.Windows.Forms.GroupBox grpPost;
        private System.Windows.Forms.GroupBox grpPostType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pPhoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog OfgPhoto;
        private System.Windows.Forms.Button bPhotoBrowse;
        private System.Windows.Forms.RichTextBox rtbPhoto;
        private System.Windows.Forms.Panel pvideo;
        private System.Windows.Forms.RichTextBox rtbvideo;
        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVideoTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog OfgVideo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbTime;
    }
}