using System;
using System.Collections.Generic;
using FPageManager.FacebookProperties;
using System.Runtime.Serialization;

namespace FPageManager.Objects
{
    [DataContract]
    public class User : FacebookBaseObject
    {
        #region Properties

        [DataMember(Name = "about", IsRequired = false, EmitDefaultValue = true)]
        public string About { get; set; }

        [DataMember(Name = "bio", IsRequired = false, EmitDefaultValue = true)]
        public string Bio { get; set; }

        [DataMember(Name = "birthday", IsRequired = false, EmitDefaultValue = true)]
        public string Birthday { get; set; }

        [DataMember(Name = "email", IsRequired = false, EmitDefaultValue = true)]
        public string Email { get; set; }

        [DataMember(Name = "first_name", IsRequired = false, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        [DataMember(Name = "middle_name", IsRequired = false, EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        [DataMember(Name = "last_name", IsRequired = false, EmitDefaultValue = true)]
        public string LastName { get; set; }

        [DataMember(Name = "gender", IsRequired = false, EmitDefaultValue = true)]
        public string Gender { get; set; }

        [DataMember(Name = "website", IsRequired = false, EmitDefaultValue = true)]
        public string Website { get; set; }

        [DataMember(Name = "viewer_can_send_gift", IsRequired = false, EmitDefaultValue = true)]
        public bool ViewerCanSendGift { get; set; }

        [DataMember(Name = "verified", IsRequired = false, EmitDefaultValue = true)]
        public bool Verified { get; set; }

        [DataMember(Name = "third_party_id", IsRequired = false, EmitDefaultValue = true)]
        public string ThirdPartyId { get; set; }

        [DataMember(Name = "quotes", IsRequired = false, EmitDefaultValue = true)]
        public string Quotes { get; set; }

        [DataMember(Name = "religion", IsRequired = false, EmitDefaultValue = true)]
        public string Religion { get; set; }

        [DataMember(Name = "relationship_status", IsRequired = false, EmitDefaultValue = true)]
        public string RelationshipStatus { get; set; }

        [DataMember(Name = "political", IsRequired = false, EmitDefaultValue = true)]
        public string Political { get; set; }

        [DataMember(Name = "name_format", IsRequired = false, EmitDefaultValue = true)]
        public string NameFormat { get; set; }

        [DataMember(Name = "locale", IsRequired = false, EmitDefaultValue = true)]
        public string Locale { get; set; }

        [DataMember(Name = "link", IsRequired = false, EmitDefaultValue = true)]
        public string Link { get; set; }

        [DataMember(Name = "interested_in", IsRequired = false, EmitDefaultValue = true)]
        public List<string> InterestedIn { get; set; }

        [DataMember(Name = "installed", IsRequired = false, EmitDefaultValue = true)]
        public bool Installed { get; set; }

        [DataMember(Name = "is_verified", IsRequired = false, EmitDefaultValue = true)]
        public bool IsVerified { get; set; }

        [DataMember(Name = "meeting_for", IsRequired = false, EmitDefaultValue = true)]
        public List<string> MeetingFor { get; set; }

        [DataMember(Name = "timezone", IsRequired = false, EmitDefaultValue = true)]
        public decimal TimeZone { get; set; }

        [DataMember(Name = "updated_time", IsRequired = false, EmitDefaultValue = true)]
        public string UpdatedTime { get; set; }

        [DataMember(Name = "work", IsRequired = false, EmitDefaultValue = true)]
        public List<FbWork> Work { get; set; }

        [DataMember(Name = "hometown", IsRequired = false, EmitDefaultValue = true)]
        public FacebookBaseObject HomeTown { get; set; }

        [DataMember(Name = "languages", IsRequired = false, EmitDefaultValue = true)]
        public List<FacebookBaseObject> Languages { get; set; }

        [DataMember(Name = "location", IsRequired = false, EmitDefaultValue = true)]
        public FacebookBaseObject Location { get; set; }

        [DataMember(Name = "favorite_athletes", IsRequired = false, EmitDefaultValue = true)]
        public List<FacebookBaseObject> FavoriteAthletes { get; set; }

        [DataMember(Name = "favorite_teams", IsRequired = false, EmitDefaultValue = true)]
        public List<FacebookBaseObject> FavoriteTeams { get; set; }

        [DataMember(Name = "significant_other", IsRequired = false, EmitDefaultValue = true)]
        public FacebookBaseObject SignificantOther { get; set; }

        [DataMember(Name = "video_upload_limits", IsRequired = false, EmitDefaultValue = true)]
        public VideoUploadLimit VideoUploadLimits { get; set; }

        #endregion

        #region Class

        [DataContract]
        public class FbWork
        {
            [DataMember(Name = "employer", IsRequired = false, EmitDefaultValue = true)]
            public FacebookBaseObject Employer { get; set; }

            [DataMember(Name = "location", IsRequired = false, EmitDefaultValue = true)]
            public FacebookBaseObject Location { get; set; }

            [DataMember(Name = "position", IsRequired = false, EmitDefaultValue = true)]
            public FacebookBaseObject Position { get; set; }

            [DataMember(Name = "start_date", IsRequired = false, EmitDefaultValue = true)]
            public string StartDate { get; set; }

            [DataMember(Name = "end_date", IsRequired = false, EmitDefaultValue = true)]
            public string EndDate { get; set; }
        }

        [DataContract]
        public class VideoUploadLimit
        {
            [DataMember(Name = "length", IsRequired = false, EmitDefaultValue=true)]
            public int Length { get; set; }
            [DataMember(Name = "size", IsRequired = false, EmitDefaultValue = true)]
            public int Size { get; set; }
        }

        #endregion
    }
}
