using System;
using OpenStack.Serialization;

namespace OpenStack.Compute.v2_6
{
    /// <summary>
    /// Specifies how to connect a console to a <see cref="Server"/>.
    /// </summary>
    [JsonConverterWithConstructor(typeof(RootWrapperConverter), "console")]
    public class Console
    {
        /// <summary>
        /// The console type.
        /// </summary>
        public RemoteConsoleType Type { get; set; }

        /// <summary>
        /// The console URL.
        /// </summary>
        public Uri Url { get; set; }
    }
}