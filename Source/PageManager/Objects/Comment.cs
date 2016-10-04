
#region Namespaces

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using FPageManager.FacebookProperties;

#endregion

namespace FPageManager.Objects
{
    #region Class

    /// <summary>
    /// A comment on a Graph API object
    /// </summary>
    [DataContract]
    public class Comment
    {
        #region Properties

        [DataMember(Name = "id", EmitDefaultValue = true, IsRequired = false)]
        public string Id { get; set; }

        [DataMember(Name = "can_comment", EmitDefaultValue = true, IsRequired = false)]
        public bool CanComment { get; set; }

        [DataMember(Name = "can_remove", EmitDefaultValue = true, IsRequired = false)]
        public bool CanRemove { get; set; }

        [DataMember(Name = "comment_count", EmitDefaultValue = true, IsRequired = false)]
        public int CommentCount { get; set; }

        [DataMember(Name = "created_time", EmitDefaultValue = true, IsRequired = false)]
        public string CreatedTime { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject From { get; set; }

        [DataMember(Name = "like_count", EmitDefaultValue = true, IsRequired = false)]
        public int LikeCount { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = true, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "message_tags", EmitDefaultValue = true, IsRequired = false)]
        public List<MessageTag> MessageTags { get; set; }

        [DataMember(Name = "user_likes", EmitDefaultValue = true, IsRequired = false)]
        public bool UserLikes { get; set; }

        #endregion

        [DataContract]
        public class MessageTag : FacebookBaseObject
        {
            [DataMember(Name = "type", EmitDefaultValue = true, IsRequired = false)]
            public string Type { get; set; }

            [DataMember(Name = "offset", EmitDefaultValue = true, IsRequired = false)]
            public int Offset { get; set; }

            [DataMember(Name = "length", EmitDefaultValue = true, IsRequired = false)]
            public int Length { get; set; }
        }

        #region Methods

        /// <summary>
        /// Returns the data to be submitted in a POST request.
        /// </summary>
        /// <returns>Returns the data to be submitted in a POST request.</returns>
        internal string GetPostData()
        {
            StringBuilder postData = new StringBuilder();
            postData.Append("message=").Append(Message);
            return postData.ToString();
        }

        #endregion
    }

    #endregion
}
