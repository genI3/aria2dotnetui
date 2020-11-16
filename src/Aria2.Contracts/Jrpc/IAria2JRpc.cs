using Aria2.Contracts.Models;
using System.Threading.Tasks;

namespace Aria2.Contracts.Jrpc
{
    /// <summary>
    /// Aria2 JSON-RPC contract interface.
    /// <seealso href="https://aria2.github.io/manual/en/html/aria2c.html#methods"/>
    /// </summary>
    public interface IAria2JRpc
    {
        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string[] uris);

        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string secret, string[] uris);

        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string[] uris, DownloadOptions options);

        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string secret, string[] uris, DownloadOptions options);

        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string[] uris, DownloadOptions? options, int position);

        /// <summary>
        /// Adds a new download.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="uris">
        /// Array of HTTP/FTP/SFTP/BitTorrent
        /// URIs pointing to the same resource.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddUri(string secret, string[] uris, DownloadOptions? options, int position);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string torrent);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string secret, string torrent);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string torrent, string[]? uris);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string secret, string torrent, string[]? uris);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string torrent, string[]? uris, DownloadOptions options);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string secret, string torrent, string[]? uris, DownloadOptions options);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string torrent, string[]? uris, DownloadOptions? options, int position);

        /// <summary>
        /// Adds a BitTorrent download by uploading a ".torrent" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="torrent">
        /// ".torrent" file content as Base64 string.
        /// </param>
        /// <param name="uris">
        /// Array of URIs for Web-seeding.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GID of the newly registered download.
        /// </returns>
        Task<string> AddTorrent(string secret, string torrent, string[]? uris, DownloadOptions? options, int position);


        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string metalink);

        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string secret, string metalink);

        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string metalink, DownloadOptions options);

        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string secret, string metalink, DownloadOptions options);

        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string metalink, DownloadOptions? options, int position);

        /// <summary>
        /// Adds a Metalink download by uploading a ".metalink" file.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="metalink">
        /// ".metalink" file content as Base64 string.
        /// </param>
        /// <param name="options">
        /// Options for new download.
        /// </param>
        /// <param name="position">
        /// Position of new download
        /// in waiting queue.
        /// </param>
        /// <returns>
        /// GIDs of newly registered downloads.
        /// </returns>
        Task<string[]> AddMetalink(string secret, string metalink, DownloadOptions? options, int position);

        /// <summary>
        /// Removes the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">GID of download to remove.</param>
        /// <returns>GID of removed download.</returns>
        Task<string> Remove(string gid);

        /// <summary>
        /// Removes the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of download to remove.</param>
        /// <returns>GID of removed download.</returns>
        Task<string> Remove(string secret, string gid);

        /// <summary>
        /// This method removes the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">GID of download to remove.</param>
        /// <returns>GID of removed download.</returns>
        /// <remarks>
        /// This method behaves just like <see cref="Remove"/> except that
        /// this method removes the download without performing any actions
        /// which take time, such as contacting BitTorrent trackers to
        /// unregister the download first.
        /// </remarks>
        Task<string> ForceRemove(string gid);

        /// <summary>
        /// This method removes the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of download to remove.</param>
        /// <returns>GID of removed download.</returns>
        /// <remarks>
        /// This method behaves just like <see cref="Remove"/> except that
        /// this method removes the download without performing any actions
        /// which take time, such as contacting BitTorrent trackers to
        /// unregister the download first.
        /// </remarks>
        Task<string> ForceRemove(string secret, string gid);

        /// <summary>
        /// Pauses the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">GID of download to pause.</param>
        /// <returns>GID of paused download.</returns>
        Task<string> Pause(string gid);

        /// <summary>
        /// Pauses the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of download to pause.</param>
        /// <returns>GID of paused download.</returns>
        Task<string> Pause(string secret, string gid);

        /// <summary>
        /// Pauses all of the downloads.
        /// </summary>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling <see cref="Pause"/>
        /// for every active/waiting download.
        /// </remarks>
        Task<string> PauseAll();

        /// <summary>
        /// Pauses all of the downloads.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling <see cref="Pause"/>
        /// for every active/waiting download.
        /// </remarks>
        Task<string> PauseAll(string secret);

        /// <summary>
        /// Pauses the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">GID of download to pause.</param>
        /// <returns>GID of paused download.</returns>
        /// <remarks>
        /// This method behaves just like <see cref="Pause"/> except
        /// that this method pauses downloads without performing any
        /// actions which take time, such as contacting BitTorrent
        /// trackers to unregister the download first.
        /// </remarks>
        Task<string> ForcePause(string gid);

        /// <summary>
        /// Pauses the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of download to pause.</param>
        /// <returns>GID of paused download.</returns>
        /// <remarks>
        /// This method behaves just like <see cref="Pause"/> except
        /// that this method pauses downloads without performing any
        /// actions which take time, such as contacting BitTorrent
        /// trackers to unregister the download first.
        /// </remarks>
        Task<string> ForcePause(string secret, string gid);

        /// <summary>
        /// Pauses all of the downloads.
        /// </summary>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling <see cref="ForcePause"/>
        /// for every active/waiting download.
        /// </remarks>
        Task<string> ForcePauseAll();

        /// <summary>
        /// Pauses all of the downloads.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling <see cref="ForcePause"/>
        /// for every active/waiting download.
        /// </remarks>
        Task<string> ForcePauseAll(string secret);

        /// <summary>
        /// Changes the status of the download denoted
        /// by <paramref name="gid"> from paused to
        /// waiting, making the download eligible
        /// to be restarted.
        /// </summary>
        /// <param name="gid">
        /// GID of the download to unpause.
        /// </param>
        /// <returns>
        /// GID of the unpaused download.
        /// </returns>
        Task<string> Unpause(string gid);

        /// <summary>
        /// Changes the status of the download denoted
        /// by <paramref name="gid"> from paused to
        /// waiting, making the download eligible
        /// to be restarted.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download to unpause.
        /// </param>
        /// <returns>
        /// GID of the unpaused download.
        /// </returns>
        Task<string> Unpause(string secret, string gid);

        /// <summary>
        /// Changes the status of all
        /// downloads from paused to waiting.
        /// </summary>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling
        /// <see cref="Unpause"/> for every
        /// paused download.
        /// </remarks>
        Task<string> UnpauseAll();

        /// <summary>
        /// Changes the status of all
        /// downloads from paused to waiting.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method is equal to calling
        /// <see cref="Unpause"/> for every
        /// paused download.
        /// </remarks>
        Task<string> UnpauseAll(string secret);

        /// <summary>
        /// Returns the progress of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Progress of the download.
        /// </returns>
        Task<DownloadProgress> TellStatus(string gid);

        /// <summary>
        /// Returns the progress of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Progress of the download.
        /// </returns>
        Task<DownloadProgress> TellStatus(string secret, string gid);

        /// <summary>
        /// Returns the progress of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Progress of the download.
        /// </returns>
        Task<DownloadProgress> TellStatus(string gid, string[] keys);

        /// <summary>
        /// Returns the progress of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Progress of the download.
        /// </returns>
        Task<DownloadProgress> TellStatus(string secret, string gid, string[] keys);

        /// <summary>
        /// Returns the URIs used in the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of Uris with its statuses.
        /// </returns>
        Task<UriWithStatus[]> GetUris(string gid);

        /// <summary>
        /// Returns the URIs used in the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of Uris with its statuses.
        /// </returns>
        Task<UriWithStatus[]> GetUris(string secret, string gid);

        /// <summary>
        /// Returns the file list of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of files of the download.
        /// </returns>
        Task<FileInfo[]> GetFiles(string gid);

        /// <summary>
        /// Returns the file list of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of files of the download.
        /// </returns>
        Task<FileInfo[]> GetFiles(string secret, string gid);

        /// <summary>
        /// Returns a list peers of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of peers of the download.
        /// </returns>
        /// <remarks>BitTorrent only</remarks>
        Task<BitTorrentPeer[]> GetPeers(string gid);

        /// <summary>
        /// Returns a list peers of the
        /// download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Array of peers of the download.
        /// </returns>
        /// <remarks>BitTorrent only</remarks>
        Task<BitTorrentPeer[]> GetPeers(string secret, string gid);

        /// <summary>
        /// Returns currently connected HTTP(S)/FTP/SFTP
        /// servers of the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">GID of the download.</param>
        /// <returns>Array of currently connected servers.</returns>
        Task<ConnectedServer[]> GetServers(string gid);

        /// <summary>
        /// Returns currently connected HTTP(S)/FTP/SFTP
        /// servers of the download denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of the download.</param>
        /// <returns>Array of currently connected servers.</returns>
        Task<ConnectedServer[]> GetServers(string secret, string gid);

        /// <summary>
        /// Returns a list of active downloads.
        /// </summary>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellActive();

        /// <summary>
        /// Returns a list of active downloads.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellActive(string secret);

        /// <summary>
        /// Returns a list of active downloads.
        /// </summary>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellActive(string[] keys);

        /// <summary>
        /// Returns a list of active downloads.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellActive(string secret, string[] keys);

        /// <summary>
        /// Returns a list of waiting downloads, including paused ones.
        /// </summary>
        /// <param name="offset">
        /// Specifies the offset from the download waiting at the front.
        /// </param>
        /// <param name="num">
        /// Specifies the max. number of downloads to be returned.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellWaiting(int offset, int num);

        /// <summary>
        /// Returns a list of waiting downloads, including paused ones.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="offset">
        /// Specifies the offset from the download waiting at the front.
        /// </param>
        /// <param name="num">
        /// Specifies the max. number of downloads to be returned.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellWaiting(string secret, int offset, int num);

        /// <summary>
        /// Returns a list of waiting downloads, including paused ones.
        /// </summary>
        /// <param name="offset">
        /// Specifies the offset from the download waiting at the front.
        /// </param>
        /// <param name="num">
        /// Specifies the max. number of downloads to be returned.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellWaiting(int offset, int num, string[] keys);

        /// <summary>
        /// Returns a list of waiting downloads, including paused ones.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="offset">
        /// Specifies the offset from the download waiting at the front.
        /// </param>
        /// <param name="num">
        /// Specifies the max. number of downloads to be returned.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of the downloads.
        /// </returns>
        /// <remarks>
        /// <para>
        /// If <paramref name="offset"/> is a positive integer,
        /// this method returns downloads in the range of
        /// [<paramref name="offset"/>, <paramref name="offset"/> + <paramref name="num"/>).
        /// </para>
        /// <para>
        /// <paramref name="offset"/> can be a negative integer.
        /// <c><paramref name="offset"/> == -1</c> points last
        /// download in the waiting queue and <c><paramref name="offset"/> == -2</c>
        /// points the download before the last download, and so on.
        /// Downloads in the response are in reversed order then.
        /// </para>
        /// </remarks>
        /// <example>
        /// Three downloads "A","B" and "C" are waiting in this order.
        /// <c>TellWaiting(0, 1)</c> returns ["A"].
        /// <c>TellWaiting(1, 2)</c> returns ["B", "C"].
        /// <c>TellWaiting(-1, 2)</c> returns ["C", "B"].
        /// </example>
        Task<DownloadProgress[]> TellWaiting(string secret, int offset, int num, string[] keys);

        /// <summary>
        /// Returns a list of stopped downloads.
        /// </summary>
        /// <param name="offset">
        /// Specifies the offset from
        /// the least recently stopped download.
        /// </param>
        /// <param name="num">
        /// Specifies the max number
        /// of downloads to be returned.
        /// </param>
        /// <returns>
        /// Array of progress of
        /// the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellStoped(int offset, int num);

        /// <summary>
        /// Returns a list of stopped downloads.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="offset">
        /// Specifies the offset from
        /// the least recently stopped download.
        /// </param>
        /// <param name="num">
        /// Specifies the max number
        /// of downloads to be returned.
        /// </param>
        /// <returns>
        /// Array of progress of
        /// the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellStoped(string secret, int offset, int num);

        /// <summary>
        /// Returns a list of stopped downloads.
        /// </summary>
        /// <param name="offset">
        /// Specifies the offset from
        /// the least recently stopped download.
        /// </param>
        /// <param name="num">
        /// Specifies the max number
        /// of downloads to be returned.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of
        /// the downloads.
        /// </returns>
        Task<DownloadProgress[]> TellStoped(int offset, int num, string[] keys);

        /// <summary>
        /// Returns a list of stopped downloads.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="offset">
        /// Specifies the offset from
        /// the least recently stopped download.
        /// </param>
        /// <param name="num">
        /// Specifies the max number
        /// of downloads to be returned.
        /// </param>
        /// <param name="keys">
        /// Array of necessary keys
        /// of download progress.
        /// </param>
        /// <returns>
        /// Array of progress of
        /// the downloads.
        /// </returns>
        /// <remarks>
        /// See <see cref="TellWaiting"/> remarks.
        /// </remarks>
        Task<DownloadProgress[]> TellStoped(string secret, int offset, int num, string[] keys);

        /// <summary>
        /// Changes the position of the download
        /// denoted by <paramref name="gid"> in the queue.
        /// </summary>
        /// <param name="gid">GID of the download.</param>
        /// <param name="pos">Relative position.</param>
        /// <param name="how">
        /// Determines the direction from <paramref name="pos"/>.
        /// </param>
        /// <returns>
        /// Integer denoting the resulting position.
        /// </returns>
        Task<int> ChangePosition(string gid, int pos, string how);

        /// <summary>
        /// Changes the position of the download
        /// denoted by <paramref name="gid"> in the queue.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of the download.</param>
        /// <param name="pos">Relative position.</param>
        /// <param name="how">
        /// Determines the direction from <paramref name="pos"/>.
        /// </param>
        /// <returns>
        /// Integer denoting the resulting position.
        /// </returns>
        /// <remarks>
        /// If <paramref name="how"/> is POS_SET, it moves
        /// the download to a position relative to the
        /// beginning of the queue. If <paramref name="how"/>
        /// is POS_CUR, it moves the download to a position
        /// relative to the current position. If <paramref name="how"/>
        /// is POS_END, it moves the download to a position 
        /// relative to the end of the queue. If the destination
        /// position is less than 0 or beyond the end of the
        /// queue, it moves the download to the beginning or
        /// the end of the queue respectively.
        /// </remarks>
        Task<int> ChangePosition(string secret, string gid, int pos, string how);

        /// <summary>
        /// Removes the URIs in <paramref name="delUris"/> from
        /// and appends the URIs in <paramref name="addUris"/>
        /// to download denoted by <paramref name="gid"/>.
        /// </summary>
        /// <param name="gid">GID of the download.</param>
        /// <param name="fileIndex">
        /// Determines the index of the file
        /// to remove/attach given URIs.
        /// </param>
        /// <param name="delUris">URIs to remove.</param>
        /// <param name="addUris">URIs to append.</param>
        /// <returns>
        /// Array of two integers. The first integer
        /// is the number of URIs deleted. The second
        /// integer is the number of URIs added.
        /// </returns>
        Task<int[]> ChangeUri(string gid, int fileIndex, string[] delUris, string[] addUris);

        /// <summary>
        /// Removes the URIs in <paramref name="delUris"/> from
        /// and appends the URIs in <paramref name="addUris"/>
        /// to download denoted by <paramref name="gid"/>.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of the download.</param>
        /// <param name="fileIndex">
        /// Determines the index of the file
        /// to remove/attach given URIs.
        /// </param>
        /// <param name="delUris">URIs to remove.</param>
        /// <param name="addUris">URIs to append.</param>
        /// <returns>
        /// Array of two integers. The first integer
        /// is the number of URIs deleted. The second
        /// integer is the number of URIs added.
        /// </returns>
        Task<int[]> ChangeUri(string secret, string gid, int fileIndex, string[] delUris, string[] addUris);

        /// <summary>
        /// Removes the URIs in <paramref name="delUris"/> from
        /// and appends the URIs in <paramref name="addUris"/>
        /// to download denoted by <paramref name="gid"/>.
        /// </summary>
        /// <param name="gid">GID of the download.</param>
        /// <param name="fileIndex">
        /// Determines the index of the file
        /// to remove/attach given URIs.
        /// </param>
        /// <param name="delUris">URIs to remove.</param>
        /// <param name="addUris">URIs to append.</param>
        /// <param name="position">
        /// Specify where URIs are inserted
        /// in the existing waiting URI list.
        /// </param>
        /// <returns>
        /// Array of two integers. The first integer
        /// is the number of URIs deleted. The second
        /// integer is the number of URIs added.
        /// </returns>
        Task<int[]> ChangeUri(string gid, int fileIndex, string[] delUris, string[] addUris, int position);

        /// <summary>
        /// Removes the URIs in <paramref name="delUris"/> from
        /// and appends the URIs in <paramref name="addUris"/>
        /// to download denoted by <paramref name="gid"/>.
        /// </summary>
        /// <param name="secret">Authorization token.</param>
        /// <param name="gid">GID of the download.</param>
        /// <param name="fileIndex">
        /// Determines the index of the file
        /// to remove/attach given URIs.
        /// </param>
        /// <param name="delUris">URIs to remove.</param>
        /// <param name="addUris">URIs to append.</param>
        /// <param name="position">
        /// Specify where URIs are inserted
        /// in the existing waiting URI list.
        /// </param>
        /// <returns>
        /// Array of two integers. The first integer
        /// is the number of URIs deleted. The second
        /// integer is the number of URIs added.
        /// </returns>
        Task<int[]> ChangeUri(string secret, string gid, int fileIndex, string[] delUris, string[] addUris, int position);

        /// <summary>
        /// Returns options of the download
        /// denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Download options.
        /// </returns>
        /// <remarks>
        /// This method does not return options
        /// which have no default value and have
        /// not been set on the command-line, in
        /// configuration files or RPC methods.
        /// </remarks>
        Task<DownloadOptions> GetOption(string gid);

        /// <summary>
        /// Returns options of the download
        /// denoted by <paramref name="gid">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>
        /// Download options.
        /// </returns>
        Task<DownloadOptions> GetOption(string secret, string gid);

        /// <summary>
        /// Changes options of the download
        /// denoted by GID dynamically.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <param name="options">
        /// Download options to change.
        /// </param>
        /// <returns>
        /// OK for success
        /// </returns>
        Task<string> ChangeOption(string gid, DownloadOptions options);

        /// <summary>
        /// Changes options of the download
        /// denoted by GID dynamically.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <param name="options">
        /// Download options to change.
        /// </param>
        /// <returns>
        /// OK for success
        /// </returns>
        Task<string> ChangeOption(string secret, string gid, DownloadOptions options);

        /// <summary>
        /// Returns the global options.
        /// </summary>
        /// <returns>
        /// Global options.
        /// </returns>
        /// <remarks>
        /// <para>
        /// Method does not return
        /// options which have no
        /// default value and have
        /// not been set on the
        /// command-line, in
        /// configuration files
        /// or RPC methods.
        /// </para>
        /// <para>
        /// Global options are used
        /// as a template for the
        /// options of newly added downloads.
        /// <seealso cref="GetOption"/>.
        /// </para>
        /// </remarks>
        Task<GlobalOptions> GetGlobalOption();

        /// <summary>
        /// Returns the global options.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>
        /// Global options.
        /// </returns>
        /// <remarks>
        /// <para>
        /// Method does not return
        /// options which have no
        /// default value and have
        /// not been set on the
        /// command-line, in
        /// configuration files
        /// or RPC methods.
        /// </para>
        /// <para>
        /// Global options are used
        /// as a template for the
        /// options of newly added downloads.
        /// <seealso cref="GetOption"/>.
        /// </para>
        /// </remarks>
        Task<GlobalOptions> GetGlobalOption(string secret);

        /// <summary>
        /// Changes global options dynamically.
        /// </summary>
        /// <param name="options">
        /// Global options to change.
        /// </param>
        /// <returns>
        /// OK for success.
        /// </returns>
        Task<string> ChangeGlobalOption(GlobalOptions options);

        /// <summary>
        /// Changes global options dynamically.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="options">
        /// Global options to change.
        /// </param>
        /// <returns>
        /// OK for success.
        /// </returns>
        Task<string> ChangeGlobalOption(string secret, GlobalOptions options);

        /// <summary>
        /// Returns global statistics such as
        /// the overall download and upload speeds.
        /// </summary>
        /// <returns>
        /// Global stats.
        /// </returns>
        Task<Stat> GetGlobalStat();

        /// <summary>
        /// Returns global statistics such as
        /// the overall download and upload speeds.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>
        /// Global stats.
        /// </returns>
        Task<Stat> GetGlobalStat(string secret);

        /// <summary>
        /// Purges completed/error/removed
        /// downloads to free memory.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        Task<string> PurgeDownloadResult();

        /// <summary>
        /// Purges completed/error/removed
        /// downloads to free memory.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        Task<string> PurgeDownloadResult(string secret);

        /// <summary>
        /// Removes a completed/error/removed
        /// download denoted by GID from memory.
        /// </summary>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>OK for success.</returns>
        Task<string> RemoveDownloadResult(string gid);

        /// <summary>
        /// Removes a completed/error/removed
        /// download denoted by GID from memory.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <param name="gid">
        /// GID of the download.
        /// </param>
        /// <returns>OK for success.</returns>
        Task<string> RemoveDownloadResult(string secret, string gid);

        /// <summary>
        /// Returns information of aria2.
        /// </summary>
        /// <returns>
        /// aria2 info.
        /// </returns>
        Task<Aria2Info> GetVersion();

        /// <summary>
        /// Returns information of aria2.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>
        /// aria2 info.
        /// </returns>
        Task<Aria2Info> GetVersion(string secret);

        /// <summary>
        /// Returns session information.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>
        /// Session ID, which is generated
        /// each time when aria2 is invoked.
        /// </returns>
        Task<string> GetSessionInfo();

        /// <summary>
        /// Returns session information.
        /// </summary>
        /// <returns>
        /// Session ID, which is generated
        /// each time when aria2 is invoked.
        /// </returns>
        Task<string> GetSessionInfo(string secret);

        /// <summary>
        /// Shuts down aria2.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        Task<string> Shutdown();

        /// <summary>
        /// Shuts down aria2.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        Task<string> Shutdown(string secret);

        /// <summary>
        /// Shuts down aria2.
        /// </summary>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method behaves like
        /// <see cref="Shutdown"/>
        /// without performing any
        /// actions which take time,
        /// such as contacting BitTorrent
        /// trackers to unregister
        /// downloads first.
        /// </remarks>
        Task<string> ForceShutdown();

        /// <summary>
        /// Shuts down aria2.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK</returns>
        /// <remarks>
        /// This method behaves like
        /// <see cref="Shutdown"/>
        /// without performing any
        /// actions which take time,
        /// such as contacting BitTorrent
        /// trackers to unregister
        /// downloads first.
        /// </remarks>
        Task<string> ForceShutdown(string secret);

        /// <summary>
        /// Saves the current session to
        /// a file specified by the
        /// <seealso cref="GlobalOptions.SaveSession">.
        /// </summary>
        /// <returns>OK if it succeeds.</returns>
        Task<string> SaveSession();

        /// <summary>
        /// Saves the current session to
        /// a file specified by the
        /// <seealso cref="GlobalOptions.SaveSession">.
        /// </summary>
        /// <param name="secret">
        /// Authorization token.
        /// </param>
        /// <returns>OK if it succeeds.</returns>
        Task<string> SaveSession(string secret);
    }
}