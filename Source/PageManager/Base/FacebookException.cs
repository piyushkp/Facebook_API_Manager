
#region Namespaces

using System;
using System.Net;
using FPageManager.FacebookProperties;
using System.IO;
//using System.Web.Serialization;

#endregion

namespace FPageManager.Base
{
    #region Class

    /// <summary>
    /// This class represents the exception that is thrown when a Facebook exception/error occurs.
    /// </summary>
    public class FacebookException : WebException
    {
        #region Properties

        public FacebookError FacebookError { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Represents the exception that is thrown when a Facebook exception/error occurs
        /// </summary>
        /// <param name="message">Represents the exception message</param>
        public FacebookException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Represents the exception that is thrown when a Facebook exception/error occurs
        /// </summary>
        /// <param name="message">Represents the exception message</param>
        /// <param name="innerException">Represents the inner exception</param>
        public FacebookException(string message, Exception innerException)
            : base(message, innerException)
        {
            if (innerException is WebException)
            {
                try
                {
                    using (WebResponse response = (innerException as WebException).Response)
                    {
                        using (Stream data = response.GetResponseStream())
                        {
                            string text = new StreamReader(data).ReadToEnd();
                            //JavaScriptSerializer serializer = new JavaScriptSerializer();
                            //FacebookError = serializer.Deserialize<FacebookError>(text);
                        }
                    }
                }
                catch
                {
                }
            }
        }

        #endregion
    }

    #endregion
}
