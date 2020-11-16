namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Represents version information
    /// and list of enabled features of aria2
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Overall download speed (byte/sec)
        /// </summary>
        public long DownloadSpeed { get; set; }

        /// <summary>
        /// Overall upload speed(byte/sec)
        /// </summary>
        public long UploadSpeed { get; set; }

        /// <summary>
        /// The number of active downloads
        /// </summary>
        public int NumActive { get; set; }

        /// <summary>
        /// The number of waiting downloads
        /// </summary>
        public int NumWaiting { get; set; }

        /// <summary>
        /// The number of stopped downloads
        /// in the current session. This value
        /// is capped by the --max-download-result option
        /// </summary>
        public int NumStopped { get; set; }

        /// <summary>
        /// The number of stopped downloads
        /// in the current session and not
        /// capped by the --max-download-result option
        /// </summary>
        public int NumStoppedTotal { get; set; }
    }
}
