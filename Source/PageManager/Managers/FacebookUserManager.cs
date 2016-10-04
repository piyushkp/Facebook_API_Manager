
#region Namespaces

using System.Collections.Generic;
using FPageManager.Base;
using FPageManager.FacebookProperties;
using FPageManager.Objects;

#endregion

namespace FPageManager.Managers
{
    #region Class

    /// <summary>
    /// Contains methods to retrieve user details
    /// </summary>
    public class FacebookUserManager : FacebookManager
    {
        #region Member Fields

        FacebookManager facebookManager = new FacebookManager();

        #endregion

        #region Methods

        #region Basic CRUD operations

        public FBObject GetUserDetails<FBObject>(string userId,  string accessToken)
            where FBObject : class
        {
            return null;
        }

        #endregion

        #endregion
    }

    #endregion
}
