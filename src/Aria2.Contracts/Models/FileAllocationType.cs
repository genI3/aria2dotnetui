namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies allocation type of file.
    /// </summary>
    public enum FileAllocationType
    {
        /// <summary>
        /// Doesn't pre-allocate file space.
        /// </summary>
        None,
        /// <summary>
        /// Pre-allocates file space
        /// before download begins.
        /// </summary>
        Prealloc,
        /// <summary>
        /// Uses ftruncate(2) system
        /// call or platform-specific
        /// counterpart to truncate
        /// a file to a specified length.
        /// </summary>
        Trunc,
        /// <summary>
        /// Allocates large(few GiB)
        /// files almost instantly.
        /// </summary>
        Falloc
    }
}
