using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    [Serializable]
    public enum VideoStreamingMode
    {
        /// <summary>
		/// No streaming.
		/// </summary>
		None,

        /// <summary>
        /// Raises a JavaScript event.
        /// </summary>
        Event,

        /// <summary>
        /// Draws directly to a target.
        /// </summary>
        Target,

        /// <summary>
        /// Draws in a new window.
        /// </summary>
        Window
    }
}