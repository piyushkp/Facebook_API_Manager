using Facebook;
using FPageManager.Managers;
using FPageManager.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPageManager.Views
{
    public partial class CreatePost : Form
    {
        #region Members

        FacebookPostManager postManager;
        List<string> inputPhotoFiles;
        List<string> inputVideoFiles;
        bool isAsync = Convert.ToBoolean(ConfigurationManager.AppSettings["Async"]);

        #endregion

        #region C'tor

        public CreatePost(FacebookPostManager _postManager)
        {
            postManager = _postManager;
            InitializeComponent();
            rbStatus.Checked = true;
        }

        #endregion

        #region Methods

        async private void CreateNewPost()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string post_id;
                var publishPost = grpPost.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                var postType = grpPostType.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                bool isPublished = true;
                if (publishPost.Text == "UnPublished Post")
                    isPublished = false;
                Post post = new Post();
                if (postType.Text == "Status")
                {
                    post.Message = rtbPostText.Text;
                    if (dateTimePicker1.Value != null)
                    {
                        DateTime t = dateTimePicker1.Value.AddSeconds(Convert.ToDouble( tbTime.Text));
                        CreateScheduleStatusPost(post, isPublished, t);
                    }
                    else
                        post_id = CreateStatusPost(post, isPublished);
                }
                else if (postType.Text == "Photo")
                {
                    post.Message = rtbPostText.Text;
                    await CreatePhotoPost(post, isPublished);
                }
                else if (postType.Text == "Video")
                {
                    post.Message = rtbPostText.Text;
                    post.Caption = tbVideoTitle.Text;
                    await CreateVideoPost(post, isPublished);
                }
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Post succssfully created!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while posting: " + ex.Message);
            }
        }
        private string CreateScheduleStatusPost(Post post, bool isPublished, DateTime scheduleTime)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("message", post.Message);
                if (!isPublished)
                {
                    parameters.Add("published", "0");
                    parameters.Add("scheduled_publish_time", DateTimeConvertor.ToUnixTime(DateTime.Now.AddHours(1)));
                    //parameters.Add("scheduled_publish_time", DateTimeConvertor.ToUnixTime(scheduleTime));
                }
                return postManager.CreatePost(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string CreateStatusPost(Post post, bool isPublished)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("message", post.Message);
                if (!isPublished)
                {
                    parameters.Add("published", "0");
                    //parameters.Add("scheduled_publish_time", DateTimeConvertor.ToUnixTime(DateTime.Now.AddHours(1)));
                }
                return postManager.CreatePost(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async private Task CreatePhotoPost(Post post, bool isPublished)
        {
            try
            {
                List<Dictionary<string, object>> parameters = new List<Dictionary<string, object>>();
                if (inputPhotoFiles != null && inputPhotoFiles.Count > 0)
                {
                    int index = 0;
                    foreach (var item in inputPhotoFiles)
                    {
                        Dictionary<string, object> parameter = new Dictionary<string, object>();
                        FileInfo f = new FileInfo(item);
                        parameter.Add("message", post.Message);
                        if (!isPublished)
                            parameter.Add("published", "0");
                        parameter.Add("pic" + index, new FacebookMediaObject { ContentType = "image/jpeg", FileName = f.Name }.SetValue(File.ReadAllBytes(f.FullName)));
                        index++;
                        parameters.Add(parameter);
                    }
                }
                if (isAsync)
                    await postManager.UploadMultiplePhotosAsync(parameters);
                else
                    postManager.UploadMultiplePhotos(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async private Task CreateVideoPost(Post post, bool isPublished)
        {
            try
            {
                long totalSize = 0;
                List<Dictionary<string, object>> parameters = new List<Dictionary<string, object>>();
                List<string> filePaths = new List<string>();
                if (inputVideoFiles != null && inputVideoFiles.Count > 0)
                {
                    int index = 0;                  
                    foreach (var item in inputVideoFiles)
                    {
                        Dictionary<string, object> parameter = new Dictionary<string, object>();
                        FileInfo f = new FileInfo(item);
                        filePaths.Add(f.FullName);
                        totalSize += f.Length >> 20;
                        parameter.Add("description", post.Message);
                        parameter.Add("title", post.Caption);
                        if (!isPublished)
                            parameter.Add("published", "0");
                        parameter.Add("video" + index, new FacebookMediaObject { ContentType = "video/3gpp", FileName = f.Name }.SetValue(File.ReadAllBytes(f.FullName)));
                        index++;
                        parameters.Add(parameter);
                    }
                }
                // large video upload in chunk with Resumable
                if (totalSize > 10)
                {
                    foreach (var file in filePaths)
                    {
                        await postManager.UploadVideoInChunk(file);
                    }                 
                }
                else
                {
                    if (isAsync)
                        await postManager.UploadMultipleVideosAsync(parameters);
                    else
                        postManager.UploadMultipleVideos(parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Click Events

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStatus.Checked)
            {
                pPhoto.Visible = false;
                pvideo.Visible = false;
            }
        }

        private void rbPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPhoto.Checked)
            {
                pPhoto.Visible = true;
                pvideo.Visible = false;
            }
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVideo.Checked)
            {
                pvideo.Visible = true;
                pPhoto.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtbPostText.Text))
                CreateNewPost();
            else
                MessageBox.Show("Please provide post details.");
        }

        private void btnVideoBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = OfgVideo.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputVideoFiles = OfgVideo.FileNames.ToList();
                foreach (var videofilename in inputVideoFiles)
                {
                    rtbvideo.Text += videofilename + "\n";
                }
            }
        }

        private void bPhotoBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = OfgPhoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputPhotoFiles = OfgPhoto.FileNames.ToList();
                foreach (var photofilename in inputPhotoFiles)
                {
                    rtbPhoto.Text += photofilename + "\n";
                }
            }
        }

        #endregion
    }
}
