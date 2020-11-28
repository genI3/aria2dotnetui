namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies representation formats of download.
    /// </summary>
    public enum DownloadResult
    {
        /// <summary>
        /// Print GID, status, average
        /// download speed and path/URI.
        /// </summary>
        Default,
        /// <summary>
        /// Print GID, status, average
        /// download speed, percentage
        /// of progress and path/URI.
        /// </summary>
        Full,
        /// <summary>
        /// Print nothing.
        /// </summary>
        Hide
    }
}
