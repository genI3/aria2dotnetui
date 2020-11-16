namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Possible statuses of the download
    /// </summary>
    public enum DownloadStatus
    {
        Active,
        Waiting,
        Paused,
        Error,
        Complete,
        Removed
    }
}
