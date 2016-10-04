
using System.Runtime.Serialization;
namespace FPageManager.FacebookProperties
{
    [DataContract]
    public class FacebookBaseObject
    {
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = true)]
        public string Id { get; set; }

        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = true)]
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
