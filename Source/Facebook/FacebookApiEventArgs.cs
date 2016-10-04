
namespace Facebook
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents the Facebook api event args.
    /// </summary>
    public class FacebookApiEventArgs : AsyncCompletedEventArgs
    {
        /// <summary>
        /// The result.
        /// </summary>
        private readonly object _result;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApiEventArgs"/> class.
        /// </summary>
        /// <param name="error">
        /// The error.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        public FacebookApiEventArgs(Exception error, bool cancelled, object userState, object result)
            : base(error, cancelled, userState)
        {
            _result = result;
        }

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <returns>
        /// The json result.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public object GetResultData()
        {
            RaiseExceptionIfNecessary();
            return _result;
        }

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <returns>The json result.</returns>
        public TResult GetResultData<TResult>()
        {
            RaiseExceptionIfNecessary();
            return (TResult)_result;
        } 
    }
}
