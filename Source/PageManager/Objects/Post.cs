
#region Namespaces

using System;
using System.Text;
using FPageManager.FacebookProperties;
using Facebook;


#endregion

namespace FPageManager.Objects
{
    #region Class

    /// <summary>
    /// An individual entry in a profile's feed as represented in the Graph API
    /// </summary>
    /// <remarks>The User, Page, Application and Group objects have feed connections containing post objects that represent their walls. 
    /// In addition the User and Page objects have a connection named posts containing Posts made by the User and the Page respectively.</remarks>
    [Serializable]
    public class Post
    {
        #region Properties

        /// <summary>
        /// Gets the value of Id
        /// </summary>
        /// <value>The Post Id</value>
        /// <permission>Requires access_token</permission>
        public string Id { get; set; }

        /// <summary>
        /// Gets the value of From
        /// </summary>
        /// <value>Information about the user who posted the message</value>
        /// <permission>Requires access_token</permission>
        public JsonObject From { get; set; }

        /// <summary>
        /// Gets the value of To
        /// </summary>
        /// <value>Profiles mentioned or targeted in this post</value>
        /// <permission>Requires access_token</permission>
        public JsonObject To { get; set; }

        /// <summary>
        /// Gets or sets the value of Message
        /// </summary>
        /// <value>The message</value>
        /// <permission>Requires access_token</permission>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the value of is_published
        /// </summary>
        /// <value></value>
        /// <permission>Requires access_token</permission
        public bool is_published { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool is_expired { get; set; }        

        /// <summary>
        /// Gets or sets the value of Picture
        /// </summary>
        /// <value>If available, a link to the picture included with this post</value>
        /// <permission>Requires access_token</permission>
        public string Picture { get; set; }

        /// <summary>
        /// Gets or sets the value of Link
        /// </summary>
        /// <value>The link attached to this post</value>
        /// <permission>Requires access_token</permission>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the value of Caption
        /// </summary>
        /// <value>The caption of the link (appears beneath the link name)</value>
        /// <permission>Requires access_token</permission>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        /// <value>A description of the link (appears beneath the link caption)</value>
        /// <permission>Requires access_token</permission>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of Source
        /// </summary>
        /// <value>A URL to a Flash movie or video file to be embedded within the post</value>
        /// <permission>Requires access_token</permission>
        public string Source { get; set; }

        /// <summary>
        ///  Pagination previous 
        /// </summary>
        public string previous { get; set; }

        /// <summary>
        ///  pagination next
        /// </summary>
        public string next { get; set; }

        /// <summary>
        /// Gets the value of Icon
        /// </summary>
        /// <value>A link to an icon representing the type of this post</value>
        /// <permission>Requires access_token</permission>
        public string Icon { get; set; }

        /// <summary>
        /// Gets the value of Type
        /// </summary>
        /// <value>A string indicating the type for this post (including link, photo, video)</value>
        /// <permission>Requires access_token</permission>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value of Privacy
        /// </summary>
        /// <value>Privacy settings of the post.</value>
        public PostPrivacy Privacy { get; set; }

        /// <summary>
        /// Gets the value of Object_Id
        /// </summary>
        /// <value>The Facebook object id for an uploaded photo or video</value>
        /// <permission>read_stream</permission>
        public long Object_Id { get; set; }

        /// <summary>
        /// Gets the value of Application
        /// </summary>
        /// <value>Information about the application this post came from</value>
        /// <permission>read_stream</permission>
        public JsonObject Application { get; set; }

        /// <summary>
        /// Gets the value of Created_Time
        /// </summary>
        /// <value>The time the post was initially published</value>
        /// <permission>read_stream</permission>
        public Nullable<DateTime> Created_Time { get; set; }

        /// <summary>
        /// Gets the value of Updated_Time
        /// </summary>
        /// <value>The time of the last comment on this post</value>
        /// <permission>read_stream</permission>
        public Nullable<DateTime> Updated_Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Double Scheduled_Publish_Time { get; set; }

        /// <summary>
        /// Gets the value of Targeting
        /// </summary>
        /// <value>Location and language restrictions for Page posts only</value>
        /// <permission>manage_pages</permission>
        public string Targeting { get; set; }

        /// <summary>
        /// Gets the value of Comments
        /// </summary>
        /// <value>The list of comments posted on a Facebook Post</value>
        public JsonObject Comments { get; set; }

        /// <summary>
        ///  Number Of unique People Viewed this post
        /// </summary>
        public Int64 NumberOfPeopleViewed { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the data to be submitted in a POST request.
        /// </summary>
        /// <returns>Returns the data to be submitted in a POST request.</returns>
        internal string GetPostData()
        {
            StringBuilder postData = new StringBuilder();
            postData.Append("message=").Append(Message);
            if (Picture != null)
                postData.Append("&picture=").Append(Picture.ToString());
            if (Link != null)
                postData.Append("&link=").Append(Link.ToString());
            if (!string.IsNullOrEmpty(Caption))
                postData.Append("&caption=").Append(Caption);
            if (!string.IsNullOrEmpty(Description))
                postData.Append("&description=").Append(Description);
            if (Source != null)
                postData.Append("&source=").Append(Source.ToString());
            if (Icon != null)
                postData.Append("&icon=").Append(Icon.ToString());
            return postData.ToString();
        }

        #endregion
    }

    #endregion
}
