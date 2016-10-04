using System.Collections.Generic;

namespace FPageManager.FacebookProperties
{
    public class FacebookList<FBObject> where FBObject : class
    {
        public List<FBObject> data { get; set; }
    }
}
