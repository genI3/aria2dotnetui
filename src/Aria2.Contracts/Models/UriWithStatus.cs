namespace Aria2.Contracts.Models
{
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
