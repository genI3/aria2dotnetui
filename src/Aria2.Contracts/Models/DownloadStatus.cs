namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies status of the download.
    /// </summary>
    public enum DownloadStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        Active,
        /// <summary>
        /// Waiting.
        /// </summary>
        Waiting,
        /// <summary>
        /// paused.
        /// </summary>
        Paused,
        /// <summary>
        /// Error.
        /// </summary>
        Error,
        /// <summary>
        /// Complete.
        /// </summary>
        Complete,
        /// <summary>
        /// Removed.
        /// </summary>
        Removed
    }
}
