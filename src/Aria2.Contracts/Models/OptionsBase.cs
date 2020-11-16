using Newtonsoft.Json;

namespace Aria2.Contracts.Models
{
    public class OptionsBase
    {
        /// <summary>
        /// Gets or sets a proxy server
        /// to use for all protocols.
        /// </summary>
        [JsonProperty("all-proxy")]
        public string? AllProxy { get; set; }

        /// <summary>
        /// Gets or sets password for <see cref="AllProxy"/>.
        /// </summary>
        [JsonProperty("all-proxy-passwd")]
        public string? AllProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets user for <see cref="AllProxy"/>.
        /// </summary>
        [JsonProperty("all-proxy-user")]
        public string? AllProxyUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// restart download from scratch if the
        /// corresponding control file doesn't exist.
        /// </summary>
        [JsonProperty("allow-overwrite")]
        public bool AllowOverwrite { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// aborts download when a piece length
        /// is different from one in a control file. 
        /// </summary>
        [JsonProperty("allow-piece-length-change")]
        public bool AllowPieceLengthChange { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// always resume download.
        /// </summary>
        [JsonProperty("always-resume")]
        public bool AlwaysResume { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable asynchronous DNS.
        /// </summary>
        [JsonProperty("async-dns")]
        public bool AsyncDns { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// rename file name if the same file
        /// already exists.
        /// </summary>
        [JsonProperty("auto-file-renaming")]
        public bool AutoFileRenaming { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// allow hook command invocation after
        /// hash check <see cref="CheckIntegrity"/>
        /// in BitTorrent download.
        /// </summary>
        [JsonProperty("bt-enable-hook-after-hash-check")]
        public bool BtEnableHookAfterHashCheck { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable Local Peer Discovery.
        /// </summary>
        [JsonProperty("bt-enable-lpd")]
        public bool BtEnableLocalPeerDiscovery { get; set; }

        /// <summary>
        /// Gets or sets a comma separated
        /// list of BitTorrent tracker's
        /// announce URI to remove. 
        /// </summary>
        [JsonProperty("bt-exclude-tracker")]
        public string? BtExcludeTracker { get; set; }

        /// <summary>
        /// Gets or sets the external
        /// IP address to use in
        /// BitTorrent download and DHT.
        /// </summary>
        [JsonProperty("bt-external-ip")]
        public string? BtExternalIp { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// requires BitTorrent message payload
        /// encryption with arc4.
        /// </summary>
        [JsonProperty("bt-force-encryption")]
        public bool BtForceEncryption { get; set; }

        /// <summary>
        /// Gets or sets as value indicating
        /// continue to seed file after hash check
        /// using <see cref="CheckIntegrity"/>
        /// option and file is complete.
        /// </summary>
        [JsonProperty("bt-hash-check-seed")]
        public bool BtHashCheckSeed { get; set; }

        /// <summary>
        /// Gets or sets as value indicating
        /// try to read file saved by <see cref="BtSaveMetadata"/>
        /// option first, before getting torrent
        /// metadata from DHT when downloading
        /// with magnet link.
        /// </summary>
        [JsonProperty("bt-load-saved-metadata")]
        public bool BtLoadSavedMetadata { get; set; }

        /// <summary>
        /// Gets or sets the maximum
        /// number of peers per torrent.
        /// </summary>
        [JsonProperty("bt-max-peers")]
        public int BtMaxPeers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// download meta data only.
        /// </summary>
        [JsonProperty("bt-metadata-only")]
        public bool BtMetadataOnly { get; set; }

        /// <summary>
        /// Gets or sets the minimum
        /// level of encryption method.
        /// </summary>
        [JsonProperty("bt-min-crypto-level")]
        public string? BtMinCryptoLevel { get; set; }

        /// <summary>
        /// Gets or sets the first and last
        /// pieces of each file to download
        /// in first order.
        /// </summary>
        [JsonProperty("bt-prioritize-piece")]
        public string? BtPrioritizePiece { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// remove the unselected files when
        /// download is completed in BitTorrent. 
        /// </summary>
        [JsonProperty("bt-remove-unselected-file")]
        public bool BtRemoveUnselectedFile { get; set; }

        /// <summary>
        /// Gets or sets a value of whole download
        /// speed of every torrent when aria2
        /// temporarily increases the number of
        /// peers to try for more download speed. 
        /// </summary>
        [JsonProperty("bt-request-peer-speed-limit")]
        public string? BtRequestPeerSpeedLimit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// not accept and establish connection
        /// with legacy BitTorrent handshake
        /// (\19BitTorrent protocol) and always
        /// use Obfuscation handshake.
        /// </summary>
        [JsonProperty("bt-require-crypto")]
        public bool BtRequireCrypto { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// save meta data as ".torrent" file.
        /// </summary>
        [JsonProperty("bt-save-metadata")]
        public bool BtSaveMetadata { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// seed previously downloaded files
        /// without verifying piece hashes.
        /// </summary>
        [JsonProperty("bt-seed-unverified")]
        public bool BtSeedUnverified { get; set; }

        /// <summary>
        /// Gets or sets a value that indiacting
        /// stop BitTorrent download if download
        /// speed is 0 in consecutive
        /// <paramref name="BtStopTimeout"/> seconds. 
        /// </summary>
        [JsonProperty("bt-stop-timeout")]
        public int BtStopTimeout { get; set; }

        /// <summary>
        /// Gets or sets a comma separated
        /// list of additional BitTorrent
        /// tracker's announce URI.
        /// </summary>
        [JsonProperty("bt-tracker")]
        public string? BtTracker { get; set; }

        /// <summary>
        /// Gets or sets he connect timeout in
        /// seconds to establish connection to tracker. 
        /// </summary>
        [JsonProperty("bt-tracker-connect-timeout")]
        public int BtTrackerConnectTimeout { get; set; }

        /// <summary>
        /// Gets or sets the interval in
        /// seconds between tracker requests.
        /// </summary>
        [JsonProperty("bt-tracker-interval")]
        public int BtTrackerInterval { get; set; }

        /// <summary>
        /// Gets or sets timeout in seconds.
        /// </summary>
        [JsonProperty("bt-tracker-timeout")]
        public int BtTrackerTimeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// check file integrity by validating
        /// piece hashes or a hash of entire file. 
        /// </summary>
        [JsonProperty("check-integrity")]
        public bool CheckIntegrity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// download file only when the local
        /// file is older than remote file.
        /// </summary>
        [JsonProperty("conditional-get")]
        public bool ConditionalGet { get; set; }

        /// <summary>
        /// Gets or sets the connect timeout
        /// in seconds to establish connection
        /// to HTTP/FTP/proxy server.
        /// </summary>
        [JsonProperty("connect-timeout")]
        public int ConnectTimeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// handle quoted string in
        /// 'Content-Disposition' header as
        /// UTF-8 instead of ISO-8859-1.
        /// </summary>
        [JsonProperty("content-disposition-default-utf8")]
        public bool ContentDispositionDefaultUtf8 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// continue downloading a partially
        /// downloaded file.
        /// </summary>
        [JsonProperty("continue")]
        public bool Continue { get; set; }

        /// <summary>
        /// Gets or sets the directory
        /// to store the downloaded file.
        /// </summary>
        [JsonProperty("dir")]
        public string? Directory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// check whether the remote file is
        /// available and doesn't download data.
        /// </summary>
        [JsonProperty("dry-run")]
        public bool DryRun { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable HTTP/1.1 persistent connection.
        /// </summary>
        [JsonProperty("enable-http-keep-alive")]
        public bool EnableHttpKeepAlive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable HTTP/1.1 pipelining.
        /// </summary>
        [JsonProperty("enable-http-pipelining")]
        public bool EnableHttpPipelining { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable map files into memory.
        /// </summary>
        [JsonProperty("enable-mmap")]
        public bool EnableMmap { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable Peer Exchange extension.
        /// </summary>
        [JsonProperty("enable-peer-exchange")]
        public bool EnablePeerExchange { get; set; }

        /// <summary>
        /// Gets or sets a method to
        /// use for pre-allocate file.
        /// </summary>
        [JsonProperty("file-allocation")]
        public string? FileAllocation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// how download metalink content and 
        /// store .metalink file.
        /// </summary>
        [JsonProperty("follow-metalink")]
        public string? FollowMetalink { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// how download torrent content and 
        /// store .torrent file.
        /// </summary>
        [JsonProperty("follow-torrent")]
        public string? FollowTorrent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// save download even if the download
        /// is completed or removed.
        /// </summary>
        [JsonProperty("force-save")]
        public bool ForceSave { get; set; }

        /// <summary>
        /// Gets or sets FTP password.
        /// </summary>
        [JsonProperty("ftp-passwd")]
        public string? FtpPassword { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// use the passive mode in FTP.
        /// </summary>
        [JsonProperty("ftp-pasv")]
        public bool FtpPassiveMode { get; set; }

        /// <summary>
        /// Gets or sets a proxy
        /// server for FTP.
        /// </summary>
        [JsonProperty("ftp-proxy")]
        public string? FtpProxy { get; set; }

        /// <summary>
        /// Gets or sets password 
        /// for <see cref="FtpProxy"/>.
        /// </summary>
        [JsonProperty("ftp-proxy-passwd")]
        public string? FtpProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets user 
        /// for <see cref="FtpProxy"/>.
        /// </summary>
        [JsonProperty("ftp-proxy-user")]
        public string? FtpProxyUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// reuse connection FTP.
        /// </summary>
        [JsonProperty("ftp-reuse-connection")]
        public bool FtpReuseConnection { get; set; }

        /// <summary>
        /// Gets or sets FTP transfer type.
        /// </summary>
        [JsonProperty("ftp-type")]
        public string? FtpType { get; set; }

        /// <summary>
        /// Gets or sets FTP user.
        /// </summary>
        [JsonProperty("ftp-user")]
        public string? FtpUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// abort download whether or not download
        /// is complete after hash check.
        /// </summary>
        [JsonProperty("hash-check-only")]
        public bool HashCheckOnly { get; set; }

        /// <summary>
        /// Gets or sets additional
        /// header(s) to HTTP request.
        /// </summary>
        [JsonProperty("header")]
        public string? Header { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// send 'Accept: deflate', gzip request
        /// header and inflate response if remote
        /// server responds with 'Content-Encoding: gzip'
        /// or 'Content-Encoding: deflate'.
        /// </summary>
        [JsonProperty("http-accept-gzip")]
        public bool HttpAcceptGzip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// send HTTP authorization header only
        /// when it is requested by the server.
        /// </summary>
        [JsonProperty("http-auth-challenge")]
        public bool HttpAuthChallenge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// send 'Cache-Control: no-cache' and
        /// 'Pragma: no-cache' header to
        /// avoid cached content.
        /// </summary>
        [JsonProperty("http-no-cache")]
        public bool HttpNoCache { get; set; }

        /// <summary>
        /// Gets or sets the HTTP password.
        /// </summary>
        [JsonProperty("http-passwd")]
        public string? HttpPassword { get; set; }

        /// <summary>
        /// Gets or sets a proxy
        /// server for HTTP.
        /// </summary>
        [JsonProperty("http-proxy")]
        public string? HttpProxy { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// for <see cref="HttpProxy"/>.
        /// </summary>
        [JsonProperty("http-proxy-passwd")]
        public string? HttpProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets the user
        /// for <see cref="HttpProxy"/>.
        /// </summary>
        [JsonProperty("http-proxy-user")]
        public string? HttpProxyUser { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user.
        /// </summary>
        [JsonProperty("http-user")]
        public string? HttpUser { get; set; }

        /// <summary>
        /// Gets or sets a proxy
        /// server for HTTPS.
        /// </summary>
        [JsonProperty("https-proxy")]
        public string? HttpsProxy { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// for <see cref="HttpsProxy"/>.
        /// </summary>
        [JsonProperty("https-proxy-passwd")]
        public string? HttpsProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets the user
        /// for <see cref="HttpsProxy"/>.
        /// </summary>
        [JsonProperty("https-proxy-user")]
        public string? HttpsProxyUser { get; set; }

        /// <summary>
        /// Gets or sets a value less
        /// than wich of download
        /// speed connection would be close.
        /// </summary>
        [JsonProperty("lowest-speed-limit")]
        public string? LowestSpeedLimit { get; set; }

        /// <summary>
        /// Gets or sets the maximum number
        /// of connections to one server
        /// for each download.
        /// </summary>
        [JsonProperty("max-connection-per-server")]
        public int MaxConnectionPerServer { get; set; }

        /// <summary>
        /// Gets or sets max download speed
        /// per each download in bytes/sec.
        /// </summary>
        [JsonProperty("max-download-limit")]
        public string? MaxDownloadLimit { get; set; }

        /// <summary>
        /// Gets or sets the max times
        /// to recieve "file not found"
        /// status from remote server
        /// before mark download error.
        /// </summary>
        [JsonProperty("max-file-not-found")]
        public int MaxFileNotfound { get; set; }

        /// <summary>
        /// Gets or sets the maximum
        /// file size to enable mmap.
        /// </summary>
        [JsonProperty("max-mmap-limit")]
        public long MaxMmapLimit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// number of URIs without support resume 
        /// to download file from scratch.
        /// </summary>
        [JsonProperty("max-resume-failure-tries")]
        public int MaxResumeFailureTries { get; set; }

        /// <summary>
        /// Gets or sets the number of tries.
        /// </summary>
        [JsonProperty("max-tries")]
        public int MaxTries { get; set; }

        /// <summary>
        /// Gets or sets max upload speed
        /// per each torrent in bytes/sec.
        /// </summary>
        [JsonProperty("max-upload-limit")]
        public string? MaxUploadLimit { get; set; }

        /// <summary>
        /// Gets os sets base URI to resolve
        /// relative URI in metalink:url and
        /// metalink:metaurl element in a
        /// metalink file stored in local disk.
        /// </summary>
        [JsonProperty("metalink-base-uri")]
        public string? MetalinkBaseUri { get; set; }

        /// <summary>
        /// Gets os sets a value indicating
        /// aria2 to use one of several protocols
        /// for a mirror in metalink file.
        /// </summary>
        [JsonProperty("metalink-enable-unique-protocol")]
        public bool MetalinkEnableUniqueProtocol { get; set; }

        /// <summary>
        /// Gets or sets the language
        /// of the file to download.
        /// </summary>
        [JsonProperty("metalink-language")]
        public string? MetalinkLanguage { get; set; }

        /// <summary>
        /// Gets or sets the location
        /// of the preferred server.
        /// </summary>
        [JsonProperty("metalink-location")]
        public string? MetalinkLocation { get; set; }

        /// <summary>
        /// Gets or sets the OS of
        /// the file to download.
        /// </summary>
        [JsonProperty("metalink-os")]
        public string? MetalinkOs { get; set; }

        /// <summary>
        /// Gets or sets preferred protocol
        /// for metalink download.
        /// </summary>
        [JsonProperty("metalink-preferred-protocol")]
        public string? MetalinkPreferedProtocol { get; set; }

        /// <summary>
        /// Gets or sets the version
        /// of the file to download.
        /// </summary>
        [JsonProperty("metalink-version")]
        public string? MetalinkVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// aria2 minimum file size to split 
        /// as a <c>value*2</c>.
        /// </summary>
        [JsonProperty("min-split-size")]
        public string? MinSplitSize { get; set; }

        /// <summary>
        /// Gets or sets the  maximum
        /// file size without allocation.
        /// </summary>
        [JsonProperty("no-file-allocation-limit")]
        public string? NoFileAllocationLimit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// disables netrc support.
        /// </summary>
        [JsonProperty("no-netrc")]
        public bool NoNetrc { get; set; }

        /// <summary>
        /// Gets or sets a comma separated
        /// list of host names, domains and
        /// network addresses with or without
        /// a subnet mask where no proxy
        /// should be used.
        /// </summary>
        [JsonProperty("no-proxy")]
        public string? NoProxy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable parameterized URI support.
        /// </summary>
        [JsonProperty("parameterized-uri")]
        public bool ParametrizedUri { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// pause downloads created as a result
        /// of metadata download.
        /// </summary>
        [JsonProperty("pause-metadata")]
        public bool PauseMetadata { get; set; }

        /// <summary>
        /// Gets or sets a piece length
        /// for HTTP/FTP downloads.
        /// </summary>
        [JsonProperty("piece-length")]
        public string? PieceLength { get; set; }

        /// <summary>
        /// Gets or sets the method
        /// to use in proxy request.
        /// </summary>
        [JsonProperty("proxy-method")]
        public string? ProxyMethod { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// validate chunk of data by calculating
        /// checksum while downloading a file if
        /// chunk checksums are provided.
        /// </summary>
        [JsonProperty("realtime-chunk-checksum")]
        public bool RealtimeChunkChecksum { get; set; }

        /// <summary>
        /// Gets or sets the http referrer.
        /// </summary>
        [JsonProperty("referer")]
        public string? Referer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// retrive timestamp of the remote file
        /// from the remote HTTP/FTP server and
        /// if it is available, apply it to the
        /// local file.
        /// </summary>
        [JsonProperty("remote-time")]
        public bool RemoteTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// remove control file before download.
        /// </summary>
        [JsonProperty("remove-control-file")]
        public bool? RemoveControlFile { get; set; }

        /// <summary>
        /// Gets or sets the seconds
        /// to wait between retries.
        /// </summary>
        [JsonProperty("retry-wait")]
        public int RetryWait { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// reuse already used URIs if no unused
        /// URIs are left.
        /// </summary>
        [JsonProperty("reuse-uri")]
        public bool ReuseUri { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// save the uploaded torrent or metalink
        /// meta data in the directory specified
        /// by <see cref="Directory"/> option.
        /// </summary>
        [JsonProperty("rpc-save-upload-metadata")]
        public bool RpcSaveUploadMetadata { get; set; }

        /// <summary>
        /// Gets or sets a value indicating save download with
        /// <seealso cref="GlobalOptions.SaveSession"/>
        /// option even if the file was not found on the server.
        /// </summary>
        [JsonProperty("save-not-found")]
        public bool SaveNotFound { get; set; }

        /// <summary>
        /// Gets or sets share ratio.
        /// </summary>
        [JsonProperty("seed-ratio")]
        public float SeedRatio { get; set; }

        /// <summary>
        /// Gets or sets seeding time
        /// in (fractional) minutes.
        /// </summary>
        [JsonProperty("seed-time")]
        public int SeedTime { get; set; }

        /// <summary>
        /// Gets or sets a value that 
        /// indicating number of connections
        /// for file download.
        /// </summary>
        [JsonProperty("split")]
        public int Split { get; set; }

        /// <summary>
        /// Gets or sets checksum
        /// for SSH host public key.
        /// </summary>
        [JsonProperty("ssh-host-key-md")]
        public string? SshHostKeyMd { get; set; }

        /// <summary>
        /// Gets or sets piece selection
        /// algorithm used in HTTP/FTP download.
        /// </summary>
        [JsonProperty("stream-piece-selector")]
        public string? StreamPieceSelector { get; set; }

        /// <summary>
        /// Gets or sets timeout in seconds.
        /// </summary>
        [JsonProperty("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// Gets or sets URI selection algorithm.
        /// </summary>
        [JsonProperty("uri-selector")]
        public string? UriSelectior { get; set; }

        /// <summary>
        /// Gets or sets a value indicating 
        /// use or not HEAD method for the
        /// first request to the HTTP server.
        /// </summary>
        [JsonProperty("use-head")]
        public bool UseHead { get; set; }

        /// <summary>
        /// Gets or sets user agent for HTTP(S) downloads.
        /// </summary>
        [JsonProperty("user-agent")]
        public string? UserAgent { get; set; }
    }
}
