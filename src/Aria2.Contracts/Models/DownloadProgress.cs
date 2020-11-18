namespace Aria2.Contracts.Models
{
    public class DownloadProgress
    {
        /// <summary>
        /// GID of the download
        /// </summary>
        public string Gid { get; set; } = string.Empty;

        /// <summary>
        /// Current status of this download
        /// </summary>
        public DownloadStatus Status { get; set; }

        /// <summary>
        /// Total length of the download in bytes
        /// </summary>
        public long TotalLength { get; set; }

        /// <summary>
        /// Completed length of the download in bytes
        /// </summary>
        public long CompletedLength {get; set; }

        /// <summary>
        /// Uploaded length of the download in bytes
        /// </summary>
        public long UploadLength { get; set; }

        /// <summary>
        /// Hexadecimal representation of the download progress.
        /// The highest bit corresponds to the piece at index 0.
        /// Any set bits indicate loaded pieces, while unset
        /// bits indicate not yet loaded and/or missing pieces.
        /// Any overflow bits at the end are set to zero.
        /// When the download was not started yet, this key
        /// will not be included in the response.
        /// </summary>
        public string? Bitfield { get; set; }

        /// <summary>
        /// Download speed of this
        /// download measured in bytes/sec
        /// </summary>
        public long DownloadSpeed { get; set; }

        /// <summary>
        /// Upload speed of this 
        /// download measured in bytes/sec
        /// </summary>
        public long UploadSpeed { get; set; }

        /// <summary>
        /// InfoHash
        /// </summary>
        /// <remarks>BitTorrent only</remarks>
        public string? InfoHash { get; set; }

        /// <summary>
        /// The number of seeders aria2 has connected to
        /// </summary>
        /// <remarks>BitTorrent only</remarks>
        public int? NumSeeders { get; set; }

        /// <summary>
        /// <c>true</c> if the local endpoint
        /// is a seeder, otherwise - <c>false</c>
        /// </summary>
        /// <remarks>BitTorrent only</remarks>
        public bool? Seeder { get; set; }

        /// <summary>
        /// Piece length in bytes
        /// </summary>
        public int PieceLength { get; set; }

        /// <summary>
        /// The number of pieces
        /// </summary>
        public long NumPieces { get; set; }

        /// <summary>
        /// The number of peers/servers aria2 has connected to
        /// </summary>
        public int Connections { get; set; }

        /// <summary>
        /// The code of the last error
        /// for this item, if any
        /// </summary>
        /// <remarks>
        /// This value is only available
        /// for stopped/completed downloads
        /// </remarks>
        public int ErrorCode { get; set; }

        /// <summary>
        /// The (hopefully) human readable error
        /// message associated to <see cref="ErrorCode"/>
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        /// List of GIDs which are generated
        /// as the result of this download
        /// </summary>
        public string[]? FollowedBy { get; set; }

        /// <summary>
        /// The reverse link for <see cref="FollowedBy"/>
        /// </summary>
        public string? Following { get; set; }

        /// <summary>
        /// GID of a parent download
        /// </summary>
        public string? BelongsTo { get; set; }

        /// <summary>
        /// Directory to save files
        /// </summary>
        public string Dir { get; set; } = string.Empty;

        /// <summary>
        /// The list of files
        /// </summary>
        public FileInfo[]? Files { get; set; }

        /// <summary>
        /// Information retrieved from the .torrent file
        /// </summary>
        /// <remarks>BitTorrent only</remarks>
        public BitTorrentData? Bittorrent { get; set; }
        
        /// <summary>
        /// The number of verified number
        /// of bytes while the files are
        /// being hash checked
        /// </summary>
        public long VerifiedLength { get; set; }

        /// <summary>
        /// <c>true</c> if this download is
        /// waiting for the hash check in a
        /// queue, otherwise - <c>false</c>
        /// </summary>
        public bool VerifyIntegrityPending { get; set; }
    }
}