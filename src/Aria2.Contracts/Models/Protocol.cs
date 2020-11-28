namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies direct connection protocols.
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// Reserved/Default.
        /// </summary>
        None,
        /// <summary>
        /// HTTP.
        /// </summary>
        Http,
        /// <summary>
        /// Secure HTTP.
        /// </summary>
        Https,
        /// <summary>
        /// FTP.
        /// </summary>
        Ftp
    }
}
