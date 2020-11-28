using System;

namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Represents information about download Servers.
    /// </summary>
    public class ConnectedServer
    {
        /// <summary>
        /// Index of the file
        /// </summary>
        /// <value>
        /// Starting at 1, in the same
        /// order as files appear in
        /// the multi-file metalink
        /// </value>
        public int Index { get; set; }

        /// <summary>
        /// Array of used servers
        /// </summary>
        public ServerInfo[] Servers { get; set; } = Array.Empty<ServerInfo>();
    }
}
