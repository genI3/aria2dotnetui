namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies encryption method provided by peer.
    /// </summary>
    public enum BittorrentCryptoLevel
    {
        /// <summary>
        /// ARC4 encryption method.
        /// </summary>
        Arc4,
        /// <summary>
        /// Plain encryption method.
        /// </summary>
        Plain
    }
}
