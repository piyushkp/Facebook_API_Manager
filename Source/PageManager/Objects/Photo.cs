using System;
using System.Runtime.Serialization;
using FPageManager.FacebookProperties;

namespace FPageManager.Objects
{
    [DataContract]
    public class Photo : FacebookBaseObject
    {
        [DataMember(Name="album", EmitDefaultValue=true, IsRequired=false)]
        public FacebookBaseObject Album { get; set; }

        [DataMember(Name = "backdated_time", EmitDefaultValue = true, IsRequired = false)]
        public string BackDatedTime { get; set; }

        [DataMember(Name = "backdated_time_granularity", EmitDefaultValue = true, IsRequired = false)]
        public string BackDatedTimeGranularity { get; set; }

        [DataMember(Name = "created_time", EmitDefaultValue = true, IsRequired = false)]
        public string CreatedTime { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject From { get; set; }

        [DataMember(Name = "height", EmitDefaultValue = true, IsRequired = false)]
        public int Height { get; set; }

        [DataMember(Name = "icon", EmitDefaultValue = true, IsRequired = false)]
        public string Icon { get; set; }

        [DataMember(Name = "images", EmitDefaultValue = true, IsRequired = false)]
        public FacebookList<string> Images { get; set; }

        [DataMember(Name = "name_tags", EmitDefaultValue = true, IsRequired = false)]
        public FacebookList<object> NameTags { get; set; }

        [DataMember(Name = "page_story_id", EmitDefaultValue = true, IsRequired = false)]
        public string PageStoryID { get; set; }

        [DataMember(Name = "picture", EmitDefaultValue = true, IsRequired = false)]
        public Uri Picture { get; set; }

        [DataMember(Name = "place", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject Place { get; set; }

        [DataMember(Name = "source", EmitDefaultValue = true, IsRequired = false)]
        public Uri Source { get; set; }

        [DataMember(Name = "updated_time", EmitDefaultValue = true, IsRequired = false)]
        public string UpdatedTime { get; set; }

        [DataMember(Name = "width", EmitDefaultValue = true, IsRequired = false)]
        public string Width { get; set; }
    }
}
