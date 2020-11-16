using System.Collections.Generic;

namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Info about aria2
    /// </summary>
    public class Aria2Info
    {
        /// <summary>
        /// Version number
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// List of enabled features
        /// </summary>
        public Dictionary<string, string> EnabledFeatures { get; set; } = new();
    }
}