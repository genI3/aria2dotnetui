namespace Aria2.Contracts.Models
{
    public class BitTorrentPeer
    {
        /// <summary>
        /// Percent-encoded peer ID
        /// </summary>
        public string PeerId { get; set; } = string.Empty;

        /// <summary>
        /// IP address of the peer
        /// </summary>
        public string Ip { get; set; } = string.Empty;

        /// <summary>
        /// Port number of the peer
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Hexadecimal representation
        /// of the download progress of the peer
        /// </summary>
        /// <value>
        /// The highest bit corresponds to the
        /// piece at index 0. Set bits indicate 
        /// the piece is available and unset bits
        /// indicate the piece is missing. Any
        /// spare bits at the end are set to zero.
        /// </value>
        public string? Bitfield { get; set; }

        /// <summary>
        /// <c>true</c> if aria2 is choking
        /// the peer, otherwise - <c>false</c>
        /// </summary>
        public bool AmChoking { get; set; }

        /// <summary>
        /// <c>true</c> if the peer is
        /// choking aria2, otherwise - <c>false</c>
        /// </summary>
        public bool PeerChoking { get; set; }

        /// <summary>
        /// Download speed (byte/sec) that
        /// this client obtains from the peer
        /// </summary>
        public long DownloadSpeed { get; set; }

        /// <summary>
        /// Upload speed(byte/sec) that
        /// this client uploads to the peer
        /// </summary>
        public long UploadSpeed { get; set; }

        /// <summary>
        /// <c>true</c> if this peer
        /// is a seeder, otherwise - <c>false</c>
        /// </summary>
        public bool Seeder { get; set; }
    }
}
