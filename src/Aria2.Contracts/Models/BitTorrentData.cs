using System;

namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Information from the .torrent
    /// </summary>
    public class BitTorrentData
    {
        /// <summary>
        /// List of lists of announce URIs
        /// </summary>
        public string[][] AnnounceList { get; set; } = Array.Empty<string[]>();

        /// <summary>
        /// The comment of the torrent
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// The creation time of the torrent
        /// </summary>
        public long CreationDate { get; set; }

        /// <summary>
        /// File mode of the torrent
        /// </summary>
        public BittorrentMode Mode { get; set; }

        /// <summary>
        /// Data from Info dictionary
        /// </summary>
        public BitTorrentInfo Info { get; set; } = new();
    }
}
