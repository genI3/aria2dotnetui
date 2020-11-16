using System;

namespace Aria2.Contracts.Models
{
    public class FileInfo
    {
        /// <summary>
        /// Index of the file,
        /// starting at 1, in the
        /// same order as files
        /// appear in the multi-file torrent
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// File path
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// File size in bytes
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// Completed length of
        /// this file in bytes
        /// </summary>
        public long CompletedLength { get; set; }

        /// <summary>
        /// <c>true</c> if this file is
        /// selected by <c>--select-file</c>
        /// option. If <c>--select-file</c>
        /// is not specified or this is
        /// single-file torrent or not a
        /// torrent download at all, this
        /// value is always <c>true</c>,
        /// otherwise - <c>false</c>.
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// Array of URIs for this file
        /// </summary>
        public UriWithStatus[] Uris { get; set; } = Array.Empty<UriWithStatus>();
    }
}
