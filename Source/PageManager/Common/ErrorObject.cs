
namespace FPageManager.FacebookProperties
{
    #region Class

    /// <summary>
    /// Represents an exception / error returned by Facebook servers when an invalid operation takes place
    /// </summary>
    public class ErrorObject
    {
        #region Properties

        /// <summary>
        /// Gets the value of Message
        /// </summary>
        /// <value>The Message returned by Facebook</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets the value of Type
        /// </summary>
        /// <value>The type of Facebook exception occurred</value>
        public string Type { get; set; }

        public string Code { get; set; }

        public string Error_SubCode { get; set; }

        #endregion
    }

    #endregion
}
