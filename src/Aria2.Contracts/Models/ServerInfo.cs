namespace Aria2.Contracts.Models
{
    public class ServerInfo
    {
        /// <summary>
        /// Original URI
        /// </summary>
        public string Uri { get; set; } = string.Empty;

        /// <summary>
        /// This is the URI currently used for downloading
        /// </summary>
        /// <value></value>
        public string CurrentUri { get; set; } = string.Empty;

        /// <summary>
        /// Download speed (byte/sec)
        /// </summary>
        public long DownloadSpeed { get; set; }
    }
}
