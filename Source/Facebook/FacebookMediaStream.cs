﻿
namespace Facebook
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// Represents a media stream such as a photo or a video.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
    [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
    public class FacebookMediaStream : IDisposable
    {
        /// <summary>
        /// The value of the media stream.
        /// </summary>
        private Stream _value;

        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>The type of the content.</value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName { get; set; }

        /// <summary>
        /// Sets the value of the media stream.
        /// </summary>
        /// <param name="value">The media stream value.</param>
        /// <returns>Facebook Media Stream</returns>
        public FacebookMediaStream SetValue(Stream value)
        {
            _value = value;
            return this;
        }

        /// <summary>
        /// Gets the value of the media stream.
        /// </summary>
        /// <returns>The value of the media stream.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public Stream GetValue()
        {
            return _value;
        }

        /// <summary>
        /// Releases all resources used by the <see cref="T:System.IO.Stream"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
        public void Dispose()
        {
            var stream = GetValue();
            if (stream != null)
                stream.Dispose();
        }
    }
}