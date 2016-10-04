using System;
using System.Runtime.Serialization;
using FPageManager.FacebookProperties;

namespace FPageManager.Objects
{
    [DataContract]
    public class Video : FacebookBaseObject
    {
        [DataMember(Name = "created_time", EmitDefaultValue = true, IsRequired = false)]
        public string CreatedTime { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = true, IsRequired = false)]
        public string Description { get; set; }

        [DataMember(Name = "embed_html", EmitDefaultValue = true, IsRequired = false)]
        public string EmbedHtml { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject From { get; set; }

        [DataMember(Name = "icon", EmitDefaultValue = true, IsRequired = false)]
        public Uri Icon { get; set; }

        [DataMember(Name = "length", EmitDefaultValue = true, IsRequired = false)]
        public float Length { get; set; }

        [DataMember(Name = "picture", EmitDefaultValue = true, IsRequired = false)]
        public Uri Picture { get; set; }

        [DataMember(Name = "source", EmitDefaultValue = true, IsRequired = false)]
        public Uri Source { get; set; }

        [DataMember(Name = "thumb", EmitDefaultValue = true, IsRequired = false)]
        public Uri Thumb { get; set; }

        [DataMember(Name = "updated_time", EmitDefaultValue = true, IsRequired = false)]
        public string UpdatedTime { get; set; }
    }
}
