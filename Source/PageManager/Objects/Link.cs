using System;
using System.Runtime.Serialization;
using FPageManager.FacebookProperties;

namespace FPageManager.Objects
{
    [DataContract]
    public class Link : FacebookBaseObject
    {
        [DataMember(Name = "created_time", EmitDefaultValue = true, IsRequired = false)]
        public string CreatedTime { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = true, IsRequired = false)]
        public string Description { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject From { get; set; }

        [DataMember(Name = "icon", EmitDefaultValue = true, IsRequired = false)]
        public Uri Icon { get; set; }

        [DataMember(Name = "link", EmitDefaultValue = true, IsRequired = false)]
        public Uri SharedLink { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = true, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "picture", EmitDefaultValue = true, IsRequired = false)]
        public Uri Picture { get; set; }
    }
}
