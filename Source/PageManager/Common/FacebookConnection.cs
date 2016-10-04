using System.Collections.Generic;

namespace FPageManager.Common
{
    public class FacebookConnection<ConnectionType> where ConnectionType: class
    {
        public List<ConnectionType> data { get; set; }
    }
}
