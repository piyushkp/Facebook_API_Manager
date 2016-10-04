using System;
using FPageManager.FacebookProperties;
using System.Runtime.Serialization;

namespace FPageManager.Objects
{
    [DataContract]
    public class Page : FacebookBaseObject
    {
        [DataMember(Name="about", EmitDefaultValue=true, IsRequired=false)]
        public string About { get; set; }

        [DataMember(Name="attire", EmitDefaultValue=true, IsRequired=false)]
        public string Attire { get; set; }

        [DataMember(Name="band_members", EmitDefaultValue=true, IsRequired=false)]
        public string BandMembers { get; set; }

        [DataMember(Name = "best_page", EmitDefaultValue = true, IsRequired = false)]
        public FacebookBaseObject Best_Page { get; set; }

        [DataMember(Name = "birthday", EmitDefaultValue = true, IsRequired = false)]
        public string Birthday { get; set; }

        [DataMember(Name = "booking_agent", EmitDefaultValue = true, IsRequired = false)]
        public string BookingAgent { get; set; }

        [DataMember(Name = "can_post", EmitDefaultValue = true, IsRequired = false)]
        public bool CanPost { get; set; }

        [DataMember(Name = "category", EmitDefaultValue = true, IsRequired = false)]
        public string Category { get; set; }

        [DataMember(Name = "checkins", EmitDefaultValue = true, IsRequired = false)]
        public int CheckIns { get; set; }

        [DataMember(Name = "company_overview", EmitDefaultValue = true, IsRequired = false)]
        public string CompanyOverview { get; set; }

        [DataMember(Name = "current_location", EmitDefaultValue = true, IsRequired = false)]
        public string CurrentLocation { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = true, IsRequired = false)]
        public string Description { get; set; }

        [DataMember(Name = "directed_by", EmitDefaultValue = true, IsRequired = false)]
        public string DirectedBy { get; set; }

        [DataMember(Name = "founded", EmitDefaultValue = true, IsRequired = false)]
        public string Founded { get; set; }

        [DataMember(Name = "general_info", EmitDefaultValue = true, IsRequired = false)]
        public string GeneralInfo { get; set; }

        [DataMember(Name = "general_manager", EmitDefaultValue = true, IsRequired = false)]
        public string GeneralManager { get; set; }

        [DataMember(Name = "hometown", EmitDefaultValue = true, IsRequired = false)]
        public string HomeTown { get; set; }

        [DataMember(Name = "is_permanently_closed", EmitDefaultValue = true, IsRequired = false)]
        public bool IsPermanentlyClosed { get; set; }

        [DataMember(Name = "is_published", EmitDefaultValue = true, IsRequired = false)]
        public bool IsPublished { get; set; }

        [DataMember(Name = "is_unclaimed", EmitDefaultValue = true, IsRequired = false)]
        public bool IsUnclaimed { get; set; }

        [DataMember(Name = "likes", EmitDefaultValue = true, IsRequired = false)]
        public int Likes { get; set; }

        [DataMember(Name = "link", EmitDefaultValue = true, IsRequired = false)]
        public Uri Link { get; set; }

        [DataMember(Name = "mission", EmitDefaultValue = true, IsRequired = false)]
        public string Mission { get; set; }

        [DataMember(Name = "phone", EmitDefaultValue = true, IsRequired = false)]
        public string Phone { get; set; }

        [DataMember(Name = "press_contact", EmitDefaultValue = true, IsRequired = false)]
        public string PressContact { get; set; }

        [DataMember(Name = "price_range", EmitDefaultValue = true, IsRequired = false)]
        public string PriceRange { get; set; }

        [DataMember(Name = "products", EmitDefaultValue = true, IsRequired = false)]
        public string Products { get; set; }

        [DataMember(Name = "talking_about_count", EmitDefaultValue = true, IsRequired = false)]
        public int TalkingAboutCount { get; set; }

        [DataMember(Name = "username", EmitDefaultValue = true, IsRequired = false)]
        public string UserName { get; set; }

        [DataMember(Name = "website", EmitDefaultValue = true, IsRequired = false)]
        public Link Website { get; set; }

        [DataMember(Name = "were_here_count", EmitDefaultValue = true, IsRequired = false)]
        public int WereHereCount { get; set; }
    }
}
