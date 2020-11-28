using Newtonsoft.Json;

namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Options available for download.
    /// </summary>
    public class DownloadOptions : OptionsBase
    {
        /// <summary>
        /// Gets or sets checksum.
        /// </summary>
        [JsonProperty("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        /// Gets or sets GID of the download.
        /// </summary>
        [JsonProperty("gid")]
        public string? Gid { get; set; }

        /// <summary>
        /// Gets or sets file path
        /// for file with index.
        /// </summary>
        [JsonProperty("index-out")]
        public string? IndexOut { get; set; }

        /// <summary>
        /// Gets or sets the file name
        /// of the downloaded file.
        /// </summary>
        [JsonProperty("out")]
        public string? Out { get; set; }

        /// <summary>
        /// Gets or sets a value indicating
        /// pause download after added.
        /// </summary>
        [JsonProperty("pause")]
        public bool Pause { get; set; }

        /// <summary>
        /// Get or sets file to download
        /// by specifying its index.
        /// </summary>
        [JsonProperty("select-file")]
        public string? SelectFile { get; set; }
    }
}