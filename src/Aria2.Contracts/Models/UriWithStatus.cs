namespace Aria2.Contracts.Models
{

    /// <summary>
    /// Represents a URI with its status.
    /// </summary>
    public class UriWithStatus
    {
        /// <summary>
        /// URI
        /// </summary>
        public string Uri { get; set; } = string.Empty;

        /// <summary>
        /// URI status
        /// </summary>
        public UriStatus Status { get; set; }
    }
}
