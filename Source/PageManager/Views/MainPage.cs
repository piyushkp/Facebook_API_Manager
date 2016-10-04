using Facebook;
using FPageManager.Base;
using FPageManager.Common;
using FPageManager.Managers;
using FPageManager.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace FPageManager.Views
{
    public partial class PageManager : Form
    {
        #region Members

        FacebookPostManager _postManager;
        FacebookClient fb;
        List<Post> _listPublishedPost = new List<Post>();
        List<Post> _listUnPublishedPost = new List<Post>();
        JsonObjectMapper _mapper = new JsonObjectMapper();
        bool isAsync = Convert.ToBoolean(ConfigurationManager.AppSettings["Async"]);
        #endregion

        #region C'tor

        public PageManager()
        {
            InitializeComponent();
            lblheader.Text = "Published Posts";
            INIT();
        }

        #endregion

        #region Initialization

        private void INIT()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                fb = new FacebookClient();
                fb.AppId = FacebookManager.Instance.appID;
                fb.AppSecret = FacebookManager.Instance.appSecret;
                fb.AccessToken = FacebookManager.Instance.PageToken;
                //fb.AccessToken = FacebookManager.Instance.UserToken;

                _postManager = new FacebookPostManager(fb);
                getAllPublishedPost(false, null);

                //_postManager.UploadVideoInChunk(@"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv");

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion       

        #region Get Posts

        /// <summary>
        /// Get all published posts
        /// </summary>
        async private void getAllPublishedPost(bool isPagination, string url)
        {
            try
            {
                if(isAsync)
                    _listPublishedPost = await _postManager.GetAllPublishedPostsAsync(isPagination, url);
                else
                    _listPublishedPost = _postManager.GetAllPublishedPosts(FacebookManager.Instance.pageID, isPagination, url);

                BindClass(_listPublishedPost);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting posts: "+ ex.Message);
            }
        }

        private void BindClass(List<Post> posts)
        {
            //dgPosts.DataSource = posts.Select(post => new { post.Message, post.Type,post.NumberOfPeopleViewed,post.Created_Time,post.Caption,post.Description }).ToList();
            dgPosts.DataSource = posts;
        }
        /// <summary>
        ///  Get all Unpublished posts
        /// </summary>
        private void getAllUnPublishedPost(bool isPagination, string url)
        {
            try
            {
                _listUnPublishedPost = _postManager.GetAllUnpublishedPosts(FacebookManager.Instance.pageID, isPagination, url);
                BindClass(_listUnPublishedPost);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting posts: " + ex.Message);
            }
        }

#endregion

        #region Click Events

        private void PageManager_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 5000;//5 seconds
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["AutoRefresh"].ToLower() == "true")
            {
                getAllPublishedPost(false, null);
            }
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            CreatePost _post = new CreatePost(_postManager);
            DialogResult result = _post.ShowDialog();
            if (result == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                getAllPublishedPost(false, null);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnPublishedPost_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Published Posts";
            Cursor.Current = Cursors.WaitCursor;
            getAllPublishedPost(false, null);
            Cursor.Current = Cursors.Default;
        }

        private void btnUnpublishedPost_Click(object sender, EventArgs e)
        {
            lblheader.Text = "Un-Published Posts";
            Cursor.Current = Cursors.WaitCursor;
            getAllUnPublishedPost(false,null);
            Cursor.Current = Cursors.Default;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_listPublishedPost.Count > 0)
            {
                if (!String.IsNullOrEmpty(_listPublishedPost[0].next))
                {
                    getAllPublishedPost(true, _listPublishedPost[0].next);
                }
            }
            else if (_listUnPublishedPost.Count > 0)
            {
                if (!String.IsNullOrEmpty(_listUnPublishedPost[0].next))
                    getAllUnPublishedPost(true, _listUnPublishedPost[0].next);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_listPublishedPost.Count > 0)
            {
                if (!String.IsNullOrEmpty(_listPublishedPost[0].previous))
                {
                    getAllPublishedPost(true, _listPublishedPost[0].previous);
                }
            }
            else if (_listUnPublishedPost.Count > 0)
            {
                if (!String.IsNullOrEmpty(_listUnPublishedPost[0].previous))
                    getAllUnPublishedPost(true, _listUnPublishedPost[0].previous);
            }
            Cursor.Current = Cursors.Default;
        }
        //Post x = (Post)dgPosts.CurrentRow.DataBoundItem;
        #endregion      
                
    }
}
