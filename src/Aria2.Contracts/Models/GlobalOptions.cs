using Newtonsoft.Json;

namespace Aria2.Contracts.Models
{
    public class GlobalOptions : OptionsBase
    {
        /// <summary>
        /// Gets or sets interval in sec
        /// for save control file (*.aria2)
        /// </summary>
        [JsonProperty("auto-save-interval")]
        public int AutoSaveInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// exclude seed only downloads when
        /// counting concurrent active downloads
        /// (<see cref="MaxConcurrentDownloads"/>).
        /// </summary>
        [JsonProperty("bt-detach-seed-only")]
        public bool BtDetachSeedOnly { get; set; }

        /// <summary>
        /// Gets or sets the maximum number
        /// of files to open in multi-file
        /// BitTorrent/Metalink download globally.
        /// </summary>
        [JsonProperty("bt-max-open-files")]
        public int BtMaxOpenFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// verify the peer using certificates.
        /// </summary>
        [JsonProperty("check-certificate")]
        public bool CheckCertificate { get; set; }

        /// <summary>
        /// Gets or sets path to
        /// the configuration file.
        /// </summary>
        [JsonProperty("conf-path")]
        public string? ConfPath { get; set; }

        /// <summary>
        /// Gets or sets log level
        /// to output to console.
        /// </summary>
        [JsonProperty("console-log-level")]
        public string? ConsoleLogLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// run aria2 as daemon.
        /// </summary>
        [JsonProperty("daemon")]
        public bool Daemon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// aria2 do not read all URIs and
        /// options from file at startup,
        /// but it reads one by one when
        /// it needs later. 
        /// </summary>
        [JsonProperty("deferred-input")]
        public bool DeferredInput { get; set; }

        /// <summary>
        /// Gets or sets path to file
        /// with IPv4 DHT routing table.
        /// </summary>
        [JsonProperty("dht-file-path")]
        public string? DhtFilePath { get; set; }

        /// <summary>
        /// Gets or sets path to file
        /// with IPv6 DHT routing table.
        /// </summary>
        [JsonProperty("dht-file-path6")]
        public string? DhtFilePath6 { get; set; }

        /// <summary>
        /// Gets or sets UDP listening
        /// port used by DHT (IPv4, IPv6)
        /// and UDP tracker.
        /// </summary>
        [JsonProperty("dht-listen-port")]
        public string? DhtListenPort { get; set; }

        /// <summary>
        /// Gets or sets DHT message
        /// timeout in seconds.
        /// </summary>
        [JsonProperty("dht-message-timeout")]
        public string? DhtMessageTimeOut { get; set; }

        /// <summary>
        /// Gets or sets a value
        /// indicating disable IPv6.
        /// </summary>
        [JsonProperty("disable-ipv6")]
        public bool DisableIpv6 { get; set; }

        /// <summary>
        /// Gets or sets disk
        /// cache size.
        /// </summary>
        [JsonProperty("disk-cache")]
        public string? DiskCache { get; set; }

        /// <summary>
        /// Gets or sets a way to
        /// format Download Result.
        /// </summary>
        [JsonProperty("download-result")]
        public string? DownloadResult { get; set; }

        /// <summary>
        /// Gets or sets DSCP value in
        /// outgoing IP packets of
        /// BitTorrent traffic for QoS. 
        /// </summary>
        [JsonProperty("dscp")]
        public string? Dscp { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable color output for terminal.
        /// </summary>
        [JsonProperty("enable-color")]
        public bool EnableColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable IPv4 DHT functionality.
        /// </summary>
        [JsonProperty("enable-dht")]
        public bool EnableDht { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable IPv6 DHT functionality.
        /// </summary>
        [JsonProperty("enable-dht6")]
        public bool EnableDht6 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// enable JSON-RPC/XML-RPC server.
        /// </summary>
        [JsonProperty("enable-rpc")]
        public bool EnableRpc { get; set; }

        /// <summary>
        /// Gets or sets the method
        /// for polling events.
        /// </summary>
        [JsonProperty("event-poll")]
        public string? EventPoll { get; set; }

        /// <summary>
        /// Gets or sets the help
        /// messages are classified
        /// with tags. 
        /// </summary>
        [JsonProperty("help")]
        public string? Help { get; set; }

        /// <summary>
        /// Gets or sets print sizes
        /// and speed in human readable
        /// format (e.g., 1.2Ki, 3.4Mi)
        /// in the console readout.
        /// </summary>
        [JsonProperty("human-readable")]
        public bool HumanReadable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// keep unfinished download results
        /// even if doing so exceeds <see cref="MaxDownloadResult"/>.
        /// </summary>
        [JsonProperty("keep-unfinished-download-result")]
        public bool KeepUnfinishedDownloadResult { get; set; }

        /// <summary>
        /// Gets or sets TCP port number
        /// for BitTorrent downloads. 
        /// </summary>
        [JsonProperty("listen-port")]
        public string? ListenPort { get; set; }

        /// <summary>
        /// Gets or sets the log file name.
        /// </summary>
        [JsonProperty("log")]
        public string? Log { get; set; }

        /// <summary>
        /// Gets or sets log level to output. 
        /// </summary>
        [JsonProperty("log-level")]
        public string? LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the maximum number
        /// of parallel downloads for every
        /// queue item. 
        /// </summary>
        [JsonProperty("max-concurrent-downloads")]
        public int MaxConcurrentDownloads { get; set; }

        /// <summary>
        /// Gets or sets the maximum number
        /// of download result kept in memory. 
        /// </summary>
        [JsonProperty("max-download-result")]
        public int MaxDownloadResult { get; set; }

        /// <summary>
        /// Gets or sets the maximum overall
        /// download speed in bytes/sec.
        /// </summary>
        [JsonProperty("max-overall-download-limit")]
        public string? MaxOverallDownloadLimit { get; set; }

        /// <summary>
        /// Gets or sets the maximum overall
        /// upload speed in bytes/sec.
        /// </summary>
        [JsonProperty("max-overall-upload-limit")]
        public string? MaxOverallUploadLimit { get; set; }

        /// <summary>
        /// Gets or sets the path 
        /// to the netrc file.
        /// </summary>
        [JsonProperty("netrc-path")]
        public string? NetrcPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// disable loading 'aria2.conf' file.
        /// </summary>
        [JsonProperty("no-conf")]
        public bool NoConf { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// optimizes the number of concurrent
        /// downloads according to the bandwidth available.
        /// </summary>
        [JsonProperty("optimize-concurrent-downloads")]
        public string? OptimizeConcurrentDownloads { get; set; }

        /// <summary>
        /// Gets or sets the string used
        /// during the bitorrent extended
        /// handshake for the peer's
        /// client version.
        /// </summary>
        [JsonProperty("peer-agent")]
        public string? PeerAgent { get; set; }

        /// <summary>
        /// Gets or sets the
        /// prefix of peer ID. 
        /// </summary>
        [JsonProperty("peer-id-prefix")]
        public string? PeerIdPrefix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// aria2 quiet (no console output).
        /// </summary>
        [JsonProperty("quiet")]
        public bool Quiet { get; set; }

        /// <summary>
        /// Gets or sets the soft limit
        /// of open file descriptors. 
        /// </summary>
        [JsonProperty("rlimit-nofile")]
        public string? RlimitNofile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// add Access-Control-Allow-Origin
        /// header field with value '*'
        /// to the RPC response. 
        /// </summary>
        [JsonProperty("rpc-allow-origin-all")]
        public bool RpcAllowOriginAll { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// listen incoming JSON-RPC/XML-RPC
        /// requests on all network interfaces.  
        /// </summary>
        [JsonProperty("rpc-listen-all")]
        public bool RpcListenAll { get; set; }

        /// <summary>
        /// Gets or sets a port number
        /// for JSON-RPC/XML-RPC server
        /// to listen to.
        /// </summary>
        [JsonProperty("rpc-listen-port")]
        public int RpcListenPort { get; set; }

        /// <summary>
        /// Gets or sets max size
        /// of JSON-RPC/XML-RPC request.
        /// </summary>
        [JsonProperty("rpc-max-request-size")]
        public string? RpcMaxRequestSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// RPC transport will be encrypted
        /// by SSL/TLS.
        /// </summary>
        [JsonProperty("rpc-secure")]
        public bool RpcSecure { get; set; }

        /// <summary>
        /// Gets or sets a file
        /// path forsave Cookies in
        /// Mozilla/Firefox(1.x/2.x)/Netscape format.
        /// </summary>
        [JsonProperty("save-cookies")]
        public string? SaveCookies { get; set; }

        /// <summary>
        /// Gets or sets the file path to
        /// save error/unfinished downloads.
        /// </summary>
        [JsonProperty("save-session")]
        public string? SaveSession { get; set; }

        /// <summary>
        /// Gets or sets time interval
        /// in seconds to save error/unfinished
        /// downloads to a file specified by
        /// <see cref="SaveSession"/>.
        /// </summary>
        [JsonProperty("save-session-interval")]
        public int SaveSessionInterval { get; set; }

        /// <summary>
        /// Gets or sets the file path
        /// where server saved performance profile.
        /// </summary>
        [JsonProperty("server-stat-of")]
        public string? ServerStatOf { get; set; }

        /// <summary>
        /// Gets or sets the timeout
        /// in seconds to invalidate
        /// performance profile of
        /// the servers since the 
        /// last contact to them.
        /// </summary>
        [JsonProperty("server-stat-timeout")]
        public int ServerStatTimeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// show console readout.
        /// </summary>
        [JsonProperty("show-console-readout")]
        public bool ShowConsoleReadout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// print file listing of '.torrent',
        /// '.meta4' and '.metalink' file and exit.
        /// </summary>
        [JsonProperty("show-files")]
        public bool ShowFiles { get; set; }

        /// <summary>
        /// Gets or sets the maximum
        /// socket receive buffer in bytes.
        /// </summary>
        [JsonProperty("socket-recv-buffer-size")]
        public int SocketRecieveBufferSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// redirect all console output that
        /// would be otherwise printed in
        /// stdout to stderr.
        /// </summary>
        [JsonProperty("stderr")]
        public bool StdErr { get; set; }

        /// <summary>
        /// Gets or sets a value in seconds
        /// after which the application 
        /// will be stoppedю
        /// </summary>
        [JsonProperty("stop")]
        public int Stop { get; set; }

        /// <summary>
        /// Gets or sets the interval
        /// in seconds to output
        /// download progress summary.
        /// </summary>
        [JsonProperty("summary-interval")]
        public int SummaryInterval  { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// truncate console readout to
        /// fit in a single line.
        /// </summary>
        [JsonProperty("truncate-console-readout")]
        public bool TruncateConsoleReadout { get; set; }
    }
}
